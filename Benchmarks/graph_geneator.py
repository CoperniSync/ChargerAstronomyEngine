
# This file was generated 

import pandas as pd
import matplotlib.pyplot as plt
import numpy as np

ll = pd.read_csv('benchmark_results/LatLong_frames.csv')
cm = pd.read_csv('benchmark_results/CubeMap_frames.csv')
ic = pd.read_csv('benchmark_results/Icosphere_frames.csv')

fig, axes = plt.subplots(2, 2, figsize=(14, 10))
fig.suptitle('Spatial Indexing Performance', fontsize=16, fontweight='bold')

ax1 = axes[0, 0]
ax1.plot(ll['Frame'], ll['StarsUpdated'], label='LatLong', alpha=0.7, linewidth=1, color='#1f77b4')
ax1.plot(cm['Frame'], cm['StarsUpdated'], label='CubeMap', alpha=0.7, linewidth=1, color='#ff7f0e')
ax1.plot(ic['Frame'], ic['StarsUpdated'], label='Icosphere', alpha=0.7, linewidth=1, color='#2ca02c')
ax1.set_xlabel('Frame Number')
ax1.set_ylabel('Stars Updated')
ax1.set_title('Stars Updated Per Frame')
ax1.legend()
ax1.grid(True, alpha=0.3)

ax2 = axes[0, 1]
ax2.scatter(ll['Altitude'], ll['StarsUpdated'], label='LatLong', alpha=0.4, s=5, c='#1f77b4')
ax2.scatter(cm['Altitude'], cm['StarsUpdated'], label='CubeMap', alpha=0.4, s=5, c='#ff7f0e')
ax2.scatter(ic['Altitude'], ic['StarsUpdated'], label='Icosphere', alpha=0.4, s=5, c='#2ca02c')
ax2.axvline(x=80, color='red', linestyle='--', alpha=0.5, linewidth=2, label='Polar')
ax2.set_xlabel('Camera Altitude (degrees)')
ax2.set_ylabel('Stars Updated')
ax2.set_title('Stars vs Altitude')
ax2.legend()
ax2.grid(True, alpha=0.3)

ax3 = axes[1, 0]
bp = ax3.boxplot([ll['FrameTimeMs'], cm['FrameTimeMs'], ic['FrameTimeMs']], 
                  labels=['LatLong', 'CubeMap', 'Icosphere'], 
                  patch_artist=True)
colors = ['#1f77b4', '#ff7f0e', '#2ca02c']
for patch, color in zip(bp['boxes'], colors):
    patch.set_facecolor(color)
    patch.set_alpha(0.6)
ax3.set_ylabel('Frame Time (ms)')
ax3.set_title('Frame Time Distribution')
ax3.grid(True, alpha=0.3, axis='y')

ax4 = axes[1, 1]
ranges = [(0, 30), (30, 60), (60, 80), (80, 90)]
labels = ['0-30 degrees\nEquator', '30-60 degrees\nMid', '60-80 degrees\nHigh', '80-90 degrees\nPolar']

def calc_std(df, ranges):
    stds = []
    for low, high in ranges:
        mask = (df['Altitude'] >= low) & (df['Altitude'] < high)
        subset = df[mask]['StarsUpdated']
        stds.append(subset.std() if len(subset) > 0 else 0)
    return stds

ll_std = calc_std(ll, ranges)
cm_std = calc_std(cm, ranges)
ic_std = calc_std(ic, ranges)

x = np.arange(len(labels))
width = 0.25
ax4.bar(x - width, ll_std, width, label='LatLong', color='#1f77b4', alpha=0.8)
ax4.bar(x, cm_std, width, label='CubeMap', color='#ff7f0e', alpha=0.8)
ax4.bar(x + width, ic_std, width, label='Icosphere', color='#2ca02c', alpha=0.8)
ax4.set_xlabel('Latitude Range')
ax4.set_ylabel('Std Dev (stars)')
ax4.set_title('Consistency by Latitude')
ax4.set_xticks(x)
ax4.set_xticklabels(labels)
ax4.legend()
ax4.grid(True, alpha=0.3, axis='y')

plt.tight_layout()
plt.savefig('benchmark_results/graphs.png', dpi=300, bbox_inches='tight')
print('saved graphs.png')

for name, df in [('LatLong', ll), ('CubeMap', cm), ('Icosphere', ic)]:
    print(f'\n{name}:')
    print(f'  Stars: {df["StarsUpdated"].mean():.1f} +- {df["StarsUpdated"].std():.1f}')
    print(f'  Frame: {df["FrameTimeMs"].mean():.3f}ms (95th: {df["FrameTimeMs"].quantile(0.95):.3f}ms)')
    polar = df[df['Altitude'] >= 80]
    if len(polar) > 0:
        print(f'  Polar: {polar["StarsUpdated"].mean():.1f} avg, {polar["StarsUpdated"].max():.0f} max')

plt.show()