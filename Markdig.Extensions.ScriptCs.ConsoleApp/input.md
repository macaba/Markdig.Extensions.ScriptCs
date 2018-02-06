# Report

## Prerequisites

Instantiate the Markdig.Extensions.ScriptCs into the scripting runtime:

````C#
```ScriptCs
#r Markdig.Extensions.ScriptCs.dll
using Markdig.Extensions.ScriptCs;
```
````

This only needs to be done once in your document.

```ScriptCs
#r Markdig.Extensions.ScriptCs.dll
using Markdig.Extensions.ScriptCs;
```

## Html {.pb_before}
This generates some simple HTML from ScriptCs

#### Code
```C#
MarkdownDocument.Instance.InsertHtml("<p>Hello World!</p>");
```

#### Output
```ScriptCs
MarkdownDocument.Instance.InsertHtml("<p>Hello World!</p>");
```

## Markdown {.pb_before}
This generates some simple Markdown from ScriptCs (which is then processed into HTML)

#### Code
```C#
MarkdownDocument.Instance.InsertMarkdown("Hello World!");
```

#### Output
```ScriptCs
MarkdownDocument.Instance.InsertMarkdown("Hello World!");
```

## Inline {.pb_before}
This uses inline code tags to generate some markdown.

#### Code
```
This is some `ScriptCs MarkdownDocument.Instance.InsertMarkdown("_italic_");` text.
```

#### Output
This is some `ScriptCs MarkdownDocument.Instance.InsertMarkdown("_italic_");` text.

#### Code
```
This is some `ScriptCs MarkdownDocument.Instance.InsertHtml("<em>italic</em>");` text.
```

#### Output
This is some `ScriptCs MarkdownDocument.Instance.InsertHtml("<em>italic</em>");` text.

## Exception Handling {.pb_before}
This generates a ScriptCs exception by using invalid code.

#### Code
```C#
var fakeModel = new FakeModel { Title = "Test" };
```

#### Output
```ScriptCs
var fakeModel = new FakeModel { Title = "Test" };
```

## Bootstrap Layout {.pb_before}

#### Simple content
::::{.row}
:::{.col-md-4}
Left{.text-center}
:::
:::{.col-md-4}
Middle{.text-center}
:::
:::{.col-md-4}
Right{.text-center}
:::
::::

#### Content from ScriptCs
::::{.row}
:::{.col-md-6}
```ScriptCs
MarkdownDocument.Instance.InsertMarkdown("Left half{.text-center}");
```
:::
:::{.col-md-6}
```ScriptCs
MarkdownDocument.Instance.InsertMarkdown("Right half{.text-center}");
```
:::
::::

## OxyPlot {.pb_before}

#### Code
```C#
#r OxyPlot.dll
#r System.Runtime.dll
using OxyPlot;
using OxyPlot.Series;
var myModel = new PlotModel { Title = "Example 1" };
myModel.Series.Add(new FunctionSeries(Math.Cos, 0, 10, 0.1, "cos(x)"));
var exporter = new SvgExporter { Width = 800, Height = 400 };
MarkdownDocument.Instance.InsertHtml(exporter.ExportToString(myModel));
```

#### Output
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

```ScriptCs
#load OxyPlot.csx
RenderChart();
```

## Ipsum Lorem {.pb_before}

Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vitae fermentum dui. Morbi eu scelerisque ligula. Vivamus placerat erat urna, nec dictum lacus varius eu. Ut eu enim quis elit tempor congue quis eu tortor. Duis sed finibus erat. Curabitur venenatis, est quis consectetur porta, eros lacus gravida augue, vitae consequat nibh dui ut urna. Cras at orci quis felis congue volutpat non in mauris. Donec posuere risus felis, et egestas sapien ultrices in. Aliquam elementum imperdiet est, ullamcorper fermentum mauris imperdiet ornare.

Phasellus erat ex, egestas faucibus tellus vel, volutpat feugiat est. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Fusce ornare metus ut risus viverra, ut vulputate nisl ullamcorper. Pellentesque auctor volutpat dictum. Sed vel justo massa. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Fusce consectetur sit amet est quis aliquam. Cras fermentum blandit justo, sed sagittis felis pharetra at. Interdum et malesuada fames ac ante ipsum primis in faucibus. Pellentesque id felis est. Curabitur ac massa at arcu laoreet gravida. Quisque pretium sagittis dignissim. Curabitur consequat eget purus et sollicitudin. Vivamus hendrerit sodales egestas. Ut pretium dui id erat interdum bibendum. Nulla vitae ligula in sem congue pulvinar id in libero.

Donec efficitur sollicitudin pulvinar. Sed quis diam a nibh scelerisque luctus. Aenean varius ullamcorper vulputate. Pellentesque facilisis rutrum lacus, ut bibendum magna dignissim non. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse porttitor mauris quis rhoncus blandit. Aliquam ac imperdiet risus. Vestibulum imperdiet dolor eu tortor consectetur sollicitudin. Maecenas malesuada accumsan volutpat. Quisque et elementum ligula.

Nullam augue odio, facilisis in enim id, tincidunt dapibus metus. Quisque sed faucibus ex. Suspendisse lacus libero, porta sed metus vel, tempor mattis magna. Vivamus vulputate mi vel purus fringilla ultricies. Fusce vitae consequat odio, eu porttitor nulla. Nunc nec maximus massa. Praesent porttitor porta dignissim. Nunc lacinia tempus convallis.

Nunc at metus eleifend, luctus ligula eu, vehicula leo. Fusce ultrices dui at ante laoreet auctor. Fusce non augue vel erat ultrices tristique a et sem. Pellentesque at elementum est. Quisque consectetur commodo metus, non molestie felis gravida a. Nam molestie feugiat aliquet. Pellentesque augue odio, tristique id arcu ac, rhoncus dapibus quam. Integer congue a lectus at congue. Donec accumsan elementum tempor. Praesent auctor bibendum ipsum quis ultricies. Pellentesque congue malesuada ligula, id mattis turpis ullamcorper pulvinar. Cras mi tellus, porttitor eu mauris eget, elementum dapibus nulla.

Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vitae fermentum dui. Morbi eu scelerisque ligula. Vivamus placerat erat urna, nec dictum lacus varius eu. Ut eu enim quis elit tempor congue quis eu tortor. Duis sed finibus erat. Curabitur venenatis, est quis consectetur porta, eros lacus gravida augue, vitae consequat nibh dui ut urna. Cras at orci quis felis congue volutpat non in mauris. Donec posuere risus felis, et egestas sapien ultrices in. Aliquam elementum imperdiet est, ullamcorper fermentum mauris imperdiet ornare.

Phasellus erat ex, egestas faucibus tellus vel, volutpat feugiat est. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Fusce ornare metus ut risus viverra, ut vulputate nisl ullamcorper. Pellentesque auctor volutpat dictum. Sed vel justo massa. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Fusce consectetur sit amet est quis aliquam. Cras fermentum blandit justo, sed sagittis felis pharetra at. Interdum et malesuada fames ac ante ipsum primis in faucibus. Pellentesque id felis est. Curabitur ac massa at arcu laoreet gravida. Quisque pretium sagittis dignissim. Curabitur consequat eget purus et sollicitudin. Vivamus hendrerit sodales egestas. Ut pretium dui id erat interdum bibendum. Nulla vitae ligula in sem congue pulvinar id in libero.

Donec efficitur sollicitudin pulvinar. Sed quis diam a nibh scelerisque luctus. Aenean varius ullamcorper vulputate. Pellentesque facilisis rutrum lacus, ut bibendum magna dignissim non. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse porttitor mauris quis rhoncus blandit. Aliquam ac imperdiet risus. Vestibulum imperdiet dolor eu tortor consectetur sollicitudin. Maecenas malesuada accumsan volutpat. Quisque et elementum ligula.

Nullam augue odio, facilisis in enim id, tincidunt dapibus metus. Quisque sed faucibus ex. Suspendisse lacus libero, porta sed metus vel, tempor mattis magna. Vivamus vulputate mi vel purus fringilla ultricies. Fusce vitae consequat odio, eu porttitor nulla. Nunc nec maximus massa. Praesent porttitor porta dignissim. Nunc lacinia tempus convallis.

Nunc at metus eleifend, luctus ligula eu, vehicula leo. Fusce ultrices dui at ante laoreet auctor. Fusce non augue vel erat ultrices tristique a et sem. Pellentesque at elementum est. Quisque consectetur commodo metus, non molestie felis gravida a. Nam molestie feugiat aliquet. Pellentesque augue odio, tristique id arcu ac, rhoncus dapibus quam. Integer congue a lectus at congue. Donec accumsan elementum tempor. Praesent auctor bibendum ipsum quis ultricies. Pellentesque congue malesuada ligula, id mattis turpis ullamcorper pulvinar. Cras mi tellus, porttitor eu mauris eget, elementum dapibus nulla.

Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vitae fermentum dui. Morbi eu scelerisque ligula. Vivamus placerat erat urna, nec dictum lacus varius eu. Ut eu enim quis elit tempor congue quis eu tortor. Duis sed finibus erat. Curabitur venenatis, est quis consectetur porta, eros lacus gravida augue, vitae consequat nibh dui ut urna. Cras at orci quis felis congue volutpat non in mauris. Donec posuere risus felis, et egestas sapien ultrices in. Aliquam elementum imperdiet est, ullamcorper fermentum mauris imperdiet ornare.

Phasellus erat ex, egestas faucibus tellus vel, volutpat feugiat est. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Fusce ornare metus ut risus viverra, ut vulputate nisl ullamcorper. Pellentesque auctor volutpat dictum. Sed vel justo massa. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Fusce consectetur sit amet est quis aliquam. Cras fermentum blandit justo, sed sagittis felis pharetra at. Interdum et malesuada fames ac ante ipsum primis in faucibus. Pellentesque id felis est. Curabitur ac massa at arcu laoreet gravida. Quisque pretium sagittis dignissim. Curabitur consequat eget purus et sollicitudin. Vivamus hendrerit sodales egestas. Ut pretium dui id erat interdum bibendum. Nulla vitae ligula in sem congue pulvinar id in libero.

Donec efficitur sollicitudin pulvinar. Sed quis diam a nibh scelerisque luctus. Aenean varius ullamcorper vulputate. Pellentesque facilisis rutrum lacus, ut bibendum magna dignissim non. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse porttitor mauris quis rhoncus blandit. Aliquam ac imperdiet risus. Vestibulum imperdiet dolor eu tortor consectetur sollicitudin. Maecenas malesuada accumsan volutpat. Quisque et elementum ligula.

Nullam augue odio, facilisis in enim id, tincidunt dapibus metus. Quisque sed faucibus ex. Suspendisse lacus libero, porta sed metus vel, tempor mattis magna. Vivamus vulputate mi vel purus fringilla ultricies. Fusce vitae consequat odio, eu porttitor nulla. Nunc nec maximus massa. Praesent porttitor porta dignissim. Nunc lacinia tempus convallis.

Nunc at metus eleifend, luctus ligula eu, vehicula leo. Fusce ultrices dui at ante laoreet auctor. Fusce non augue vel erat ultrices tristique a et sem. Pellentesque at elementum est. Quisque consectetur commodo metus, non molestie felis gravida a. Nam molestie feugiat aliquet. Pellentesque augue odio, tristique id arcu ac, rhoncus dapibus quam. Integer congue a lectus at congue. Donec accumsan elementum tempor. Praesent auctor bibendum ipsum quis ultricies. Pellentesque congue malesuada ligula, id mattis turpis ullamcorper pulvinar. Cras mi tellus, porttitor eu mauris eget, elementum dapibus nulla.

## Misc {.pb_before}

#### DateTime.UtcNow
The current UTC date-time is:
```ScriptCs
MarkdownDocument.Instance.InsertHtml(DateTime.UtcNow.ToString());
```