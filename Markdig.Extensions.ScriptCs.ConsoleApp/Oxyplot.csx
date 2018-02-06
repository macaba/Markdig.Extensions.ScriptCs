#r OxyPlot.dll
#r System.Runtime.dll
using OxyPlot;
using OxyPlot.Series;

public void RenderChart()
{
    var myModel = new PlotModel { Title = "Example 1" };
    myModel.Series.Add(new FunctionSeries(Math.Cos, 0, 10, 0.1, "cos(x)"));
    var exporter = new SvgExporter { Width = 800, Height = 400 };
    MarkdownDocument.Instance.InsertHtml(exporter.ExportToString(myModel));
}