# Markdig.Extensions.ScriptCs

This is an extension for Markdig that allows C# scripting to generate markdown or HTML content.

## Prerequisites

Instantiate the Markdig.Extensions.ScriptCs into the scripting runtime:

````C#
```ScriptCs
#r Markdig.Extensions.ScriptCs.dll
using Markdig.Extensions.ScriptCs;
```
````

This only needs to be done once in your document.

## Inline

##### Markdown:

```
This is some `ScriptCs MarkdownDocument.Instance.InsertMarkdown("_italic_");` text.
```

##### Output:

This is some _italic_ text.

##### Markdown:

```
This is some `ScriptCs MarkdownDocument.Instance.InsertHtml("<em>italic</em>");` text.
```

##### Output:

This is some _italic_ text.

## Code Block

##### Markdown:

````
```ScriptCs
MarkdownDocument.Instance.InsertMarkdown("Hello World!");
```
````

##### Output:

Hello World!

##### Markdown:

````
```ScriptCs
MarkdownDocument.Instance.InsertHtml("<p>Hello World!</p>");
```
````

##### Output:

Hello World!

## OxyPlot

##### Markdown:
````
```ScriptCs
#r OxyPlot.dll
#r System.Runtime.dll
using OxyPlot;
using OxyPlot.Series;
var myModel = new PlotModel { Title = "Example 1" };
myModel.Series.Add(new FunctionSeries(Math.Cos, 0, 10, 0.1, "cos(x)"));
var exporter = new SvgExporter { Width = 800, Height = 400 };
MarkdownDocument.Instance.InsertHtml(exporter.ExportToString(myModel));
```
````

##### Output:

<img src='data:image/svg+xml;utf8,<svg width="800" height="400" version="1.1" xmlns:xlink="http://www.w3.org/1999/xlink" xmlns="http://www.w3.org/2000/svg">
  <polyline points="56.8495,370.947 56.8495,374.947" style="fill:none;stroke:black;stroke-width:1"></polyline>
  <polyline points="71.7011,370.947 71.7011,374.947" style="fill:none;stroke:black;stroke-width:1"></polyline>
  <polyline points="86.5526,370.947 86.5526,374.947" style="fill:none;stroke:black;stroke-width:1"></polyline>
  <polyline points="101.4041,370.947 101.4041,374.947" style="fill:none;stroke:black;stroke-width:1"></polyline>
  <polyline points="131.1072,370.947 131.1072,374.947" style="fill:none;stroke:black;stroke-width:1"></polyline>
  <polyline points="145.9587,370.947 145.9587,374.947" style="fill:none;stroke:black;stroke-width:1"></polyline>
  <polyline points="160.8102,370.947 160.8102,374.947" style="fill:none;stroke:black;stroke-width:1"></polyline>
  <polyline points="175.6617,370.947 175.6617,374.947" style="fill:none;stroke:black;stroke-width:1"></polyline>
  <polyline points="205.3648,370.947 205.3648,374.947" style="fill:none;stroke:black;stroke-width:1"></polyline>
  <polyline points="220.2163,370.947 220.2163,374.947" style="fill:none;stroke:black;stroke-width:1"></polyline>
  <polyline points="235.0678,370.947 235.0678,374.947" style="fill:none;stroke:black;stroke-width:1"></polyline>
  <polyline points="249.9194,370.947 249.9194,374.947" style="fill:none;stroke:black;stroke-width:1"></polyline>
  <polyline points="279.6224,370.947 279.6224,374.947" style="fill:none;stroke:black;stroke-width:1"></polyline>
  <polyline points="294.4739,370.947 294.4739,374.947" style="fill:none;stroke:black;stroke-width:1"></polyline>
  <polyline points="309.3255,370.947 309.3255,374.947" style="fill:none;stroke:black;stroke-width:1"></polyline>
  <polyline points="324.177,370.947 324.177,374.947" style="fill:none;stroke:black;stroke-width:1"></polyline>
  <polyline points="353.88,370.947 353.88,374.947" style="fill:none;stroke:black;stroke-width:1"></polyline>
  <polyline points="368.7316,370.947 368.7316,374.947" style="fill:none;stroke:black;stroke-width:1"></polyline>
  <polyline points="383.5831,370.947 383.5831,374.947" style="fill:none;stroke:black;stroke-width:1"></polyline>
  <polyline points="398.4346,370.947 398.4346,374.947" style="fill:none;stroke:black;stroke-width:1"></polyline>
  <polyline points="428.1377,370.947 428.1377,374.947" style="fill:none;stroke:black;stroke-width:1"></polyline>
  <polyline points="442.9892,370.947 442.9892,374.947" style="fill:none;stroke:black;stroke-width:1"></polyline>
  <polyline points="457.8407,370.947 457.8407,374.947" style="fill:none;stroke:black;stroke-width:1"></polyline>
  <polyline points="472.6922,370.947 472.6922,374.947" style="fill:none;stroke:black;stroke-width:1"></polyline>
  <polyline points="502.3953,370.947 502.3953,374.947" style="fill:none;stroke:black;stroke-width:1"></polyline>
  <polyline points="517.2468,370.947 517.2468,374.947" style="fill:none;stroke:black;stroke-width:1"></polyline>
  <polyline points="532.0983,370.947 532.0983,374.947" style="fill:none;stroke:black;stroke-width:1"></polyline>
  <polyline points="546.9498,370.947 546.9498,374.947" style="fill:none;stroke:black;stroke-width:1"></polyline>
  <polyline points="576.6529,370.947 576.6529,374.947" style="fill:none;stroke:black;stroke-width:1"></polyline>
  <polyline points="591.5044,370.947 591.5044,374.947" style="fill:none;stroke:black;stroke-width:1"></polyline>
  <polyline points="606.3559,370.947 606.3559,374.947" style="fill:none;stroke:black;stroke-width:1"></polyline>
  <polyline points="621.2075,370.947 621.2075,374.947" style="fill:none;stroke:black;stroke-width:1"></polyline>
  <polyline points="650.9105,370.947 650.9105,374.947" style="fill:none;stroke:black;stroke-width:1"></polyline>
  <polyline points="665.762,370.947 665.762,374.947" style="fill:none;stroke:black;stroke-width:1"></polyline>
  <polyline points="680.6136,370.947 680.6136,374.947" style="fill:none;stroke:black;stroke-width:1"></polyline>
  <polyline points="695.4651,370.947 695.4651,374.947" style="fill:none;stroke:black;stroke-width:1"></polyline>
  <polyline points="725.1681,370.947 725.1681,374.947" style="fill:none;stroke:black;stroke-width:1"></polyline>
  <polyline points="740.0197,370.947 740.0197,374.947" style="fill:none;stroke:black;stroke-width:1"></polyline>
  <polyline points="754.8712,370.947 754.8712,374.947" style="fill:none;stroke:black;stroke-width:1"></polyline>
  <polyline points="769.7227,370.947 769.7227,374.947" style="fill:none;stroke:black;stroke-width:1"></polyline>
  <polyline points="784.5742,370.947 784.5742,374.947" style="fill:none;stroke:black;stroke-width:1"></polyline>
  <polyline points="34.498,350.8545 30.498,350.8545" style="fill:none;stroke:black;stroke-width:1"></polyline>
  <polyline points="34.498,334.0953 30.498,334.0953" style="fill:none;stroke:black;stroke-width:1"></polyline>
  <polyline points="34.498,317.3362 30.498,317.3362" style="fill:none;stroke:black;stroke-width:1"></polyline>
  <polyline points="34.498,300.5771 30.498,300.5771" style="fill:none;stroke:black;stroke-width:1"></polyline>
  <polyline points="34.498,267.0588 30.498,267.0588" style="fill:none;stroke:black;stroke-width:1"></polyline>
  <polyline points="34.498,250.2996 30.498,250.2996" style="fill:none;stroke:black;stroke-width:1"></polyline>
  <polyline points="34.498,233.5405 30.498,233.5405" style="fill:none;stroke:black;stroke-width:1"></polyline>
  <polyline points="34.498,216.7814 30.498,216.7814" style="fill:none;stroke:black;stroke-width:1"></polyline>
  <polyline points="34.498,183.2631 30.498,183.2631" style="fill:none;stroke:black;stroke-width:1"></polyline>
  <polyline points="34.498,166.5039 30.498,166.5039" style="fill:none;stroke:black;stroke-width:1"></polyline>
  <polyline points="34.498,149.7448 30.498,149.7448" style="fill:none;stroke:black;stroke-width:1"></polyline>
  <polyline points="34.498,132.9857 30.498,132.9857" style="fill:none;stroke:black;stroke-width:1"></polyline>
  <polyline points="34.498,99.4674 30.498,99.4674" style="fill:none;stroke:black;stroke-width:1"></polyline>
  <polyline points="34.498,82.7082 30.498,82.7082" style="fill:none;stroke:black;stroke-width:1"></polyline>
  <polyline points="34.498,65.9491 30.498,65.9491" style="fill:none;stroke:black;stroke-width:1"></polyline>
  <polyline points="34.498,49.19 30.498,49.19" style="fill:none;stroke:black;stroke-width:1"></polyline>
  <text dominant-baseline="hanging" text-anchor="middle" transform="translate(41.998,381.947)" font-family="Segoe UI" font-size="12" font-weight="400" fill="black">0</text>
  <text dominant-baseline="hanging" text-anchor="middle" transform="translate(116.2556,381.947)" font-family="Segoe UI" font-size="12" font-weight="400" fill="black">1</text>
  <text dominant-baseline="hanging" text-anchor="middle" transform="translate(190.5133,381.947)" font-family="Segoe UI" font-size="12" font-weight="400" fill="black">2</text>
  <text dominant-baseline="hanging" text-anchor="middle" transform="translate(264.7709,381.947)" font-family="Segoe UI" font-size="12" font-weight="400" fill="black">3</text>
  <text dominant-baseline="hanging" text-anchor="middle" transform="translate(339.0285,381.947)" font-family="Segoe UI" font-size="12" font-weight="400" fill="black">4</text>
  <text dominant-baseline="hanging" text-anchor="middle" transform="translate(413.2861,381.947)" font-family="Segoe UI" font-size="12" font-weight="400" fill="black">5</text>
  <text dominant-baseline="hanging" text-anchor="middle" transform="translate(487.5438,381.947)" font-family="Segoe UI" font-size="12" font-weight="400" fill="black">6</text>
  <text dominant-baseline="hanging" text-anchor="middle" transform="translate(561.8014,381.947)" font-family="Segoe UI" font-size="12" font-weight="400" fill="black">7</text>
  <text dominant-baseline="hanging" text-anchor="middle" transform="translate(636.059,381.947)" font-family="Segoe UI" font-size="12" font-weight="400" fill="black">8</text>
  <text dominant-baseline="hanging" text-anchor="middle" transform="translate(710.3166,381.947)" font-family="Segoe UI" font-size="12" font-weight="400" fill="black">9</text>
  <text dominant-baseline="hanging" text-anchor="middle" transform="translate(784.5742,381.947)" font-family="Segoe UI" font-size="12" font-weight="400" fill="black">10</text>
  <polyline points="41.998,370.947 41.998,377.947" style="fill:none;stroke:black;stroke-width:1"></polyline>
  <polyline points="116.2556,370.947 116.2556,377.947" style="fill:none;stroke:black;stroke-width:1"></polyline>
  <polyline points="190.5133,370.947 190.5133,377.947" style="fill:none;stroke:black;stroke-width:1"></polyline>
  <polyline points="264.7709,370.947 264.7709,377.947" style="fill:none;stroke:black;stroke-width:1"></polyline>
  <polyline points="339.0285,370.947 339.0285,377.947" style="fill:none;stroke:black;stroke-width:1"></polyline>
  <polyline points="413.2861,370.947 413.2861,377.947" style="fill:none;stroke:black;stroke-width:1"></polyline>
  <polyline points="487.5438,370.947 487.5438,377.947" style="fill:none;stroke:black;stroke-width:1"></polyline>
  <polyline points="561.8014,370.947 561.8014,377.947" style="fill:none;stroke:black;stroke-width:1"></polyline>
  <polyline points="636.059,370.947 636.059,377.947" style="fill:none;stroke:black;stroke-width:1"></polyline>
  <polyline points="710.3166,370.947 710.3166,377.947" style="fill:none;stroke:black;stroke-width:1"></polyline>
  <polyline points="784.5742,370.947 784.5742,377.947" style="fill:none;stroke:black;stroke-width:1"></polyline>
  <text dominant-baseline="middle" text-anchor="end" transform="translate(23.498,367.6136)" font-family="Segoe UI" font-size="12" font-weight="400" fill="black">-1</text>
  <text dominant-baseline="middle" text-anchor="end" transform="translate(23.498,283.8179)" font-family="Segoe UI" font-size="12" font-weight="400" fill="black">-0.5</text>
  <text dominant-baseline="middle" text-anchor="end" transform="translate(23.498,200.0222)" font-family="Segoe UI" font-size="12" font-weight="400" fill="black">0</text>
  <text dominant-baseline="middle" text-anchor="end" transform="translate(23.498,116.2265)" font-family="Segoe UI" font-size="12" font-weight="400" fill="black">0.5</text>
  <text dominant-baseline="middle" text-anchor="end" transform="translate(23.498,32.4308)" font-family="Segoe UI" font-size="12" font-weight="400" fill="black">1</text>
  <polyline points="34.498,367.6136 27.498,367.6136" style="fill:none;stroke:black;stroke-width:1"></polyline>
  <polyline points="34.498,283.8179 27.498,283.8179" style="fill:none;stroke:black;stroke-width:1"></polyline>
  <polyline points="34.498,200.0222 27.498,200.0222" style="fill:none;stroke:black;stroke-width:1"></polyline>
  <polyline points="34.498,116.2265 27.498,116.2265" style="fill:none;stroke:black;stroke-width:1"></polyline>
  <polyline points="34.498,32.4308 27.498,32.4308" style="fill:none;stroke:black;stroke-width:1"></polyline>
  <polyline points="41.998,32.4308 49.4238,33.2681 56.8495,35.7715 64.2753,39.916 71.7011,45.6603 79.1268,52.9469 86.5526,61.7031 93.9784,71.8412 101.4041,83.2602 108.8299,95.8457 116.2556,109.4722 123.6814,124.0034 131.1072,139.2942 138.5329,155.1917 145.9587,171.5372 153.3845,188.1673 160.8102,204.9158 168.236,221.6154 175.6617,238.0993 183.0875,254.2028 190.5133,269.7648 197.939,284.6301 205.3648,298.6499 212.7905,311.6843 220.2163,323.6031 227.6421,334.287 235.0678,343.6294 242.4936,351.5369 249.9194,357.9306 257.3451,362.7465 264.7709,365.9364 272.1966,367.4687 279.6224,367.3278 287.0482,365.5153 294.4739,362.0493 301.8997,356.9643 309.3255,350.3112 316.7512,342.1565 324.177,332.5816 331.6027,321.6822 339.0285,309.5673 346.4543,296.3578 353.88,282.1857 361.3058,267.1927 368.7316,251.5286 376.1573,235.3498 383.5831,218.818 391.0088,202.0984 398.4346,185.3581 405.8604,168.7643 413.2861,152.4829 420.7119,136.6764 428.1377,121.5028 435.5634,107.1138 442.9892,93.6531 450.4149,81.2553 457.8407,70.044 465.2665,60.1315 472.6922,51.6168 480.118,44.5848 487.5438,39.1059 494.9695,35.2349 502.3953,33.0103 509.821,32.4545 517.2468,33.573 524.6726,36.3545 532.0983,40.7714 539.5241,46.7795 546.9498,54.3187 554.3756,63.3137 561.8014,73.6747 569.2271,85.2981 576.6529,98.0678 584.0787,111.8561 591.5044,126.5255 598.9302,141.9291 606.3559,157.9132 613.7817,174.3181 621.2075,190.9798 628.6332,207.7318 636.059,224.4068 643.4848,240.8381 650.9105,256.8617 658.3363,272.3173 665.762,287.0505 673.1878,300.9142 680.6136,313.7699 688.0393,325.489 695.4651,335.9544 702.8909,345.0617 710.3166,352.7198 717.7424,358.8522 725.1681,363.3976 732.5939,366.3106 740.0197,367.5622 747.4454,367.1397 754.8712,365.0474 762.297,361.3063 769.7227,355.9537 777.1485,349.043 784.5742,340.6434" style="fill:none;stroke:rgb(78,154,6);stroke-width:2;stroke-linejoin:bevel"></polyline>
  <text dominant-baseline="hanging" text-anchor="middle" transform="translate(413.249,8)" font-family="Segoe UI" font-size="18" font-weight="700" fill="black">Example 1</text>
  <polygon points="34.498,29.0795 792,29.0795 792,370.947 34.498,370.947" style="fill:none;stroke:black;stroke-width:1"></polygon>
  <polygon points="723.502,37.0795 784,37.0795 784,63.1325 723.502,63.1325" style="fill:none;stroke:none;"></polygon>
  <text dominant-baseline="hanging" text-anchor="start" transform="translate(751.502,45.0795)" font-family="Segoe UI" font-size="12" font-weight="400" fill="black">cos(x)</text>
  <polyline points="731.502,50.106 747.502,50.106" style="fill:none;stroke:rgb(78,154,6);stroke-width:2"></polyline>
</svg>'>



