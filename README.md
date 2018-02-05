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
![./Images/oxyplot.svg](./Images/oxyplot.svg)



