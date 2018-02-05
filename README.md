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

<img src='data:image/svg+xml;%3C%3Fxml%20version%3D%221.0%22%20encoding%3D%22utf-8%22%20standalone%3D%22no%22%3F%3E%0A%3C%21DOCTYPE%20svg%20PUBLIC%20%22-//W3C//DTD%20SVG%201.1//EN%22%20%22http%3A//www.w3.org/Graphics/SVG/1.1/DTD/svg11.dtd%22%3E%0A%3Csvg%20width%3D%22800%22%20height%3D%22400%22%20version%3D%221.1%22%20xmlns%3Axlink%3D%22http%3A//www.w3.org/1999/xlink%22%20xmlns%3D%22http%3A//www.w3.org/2000/svg%22%3E'>



