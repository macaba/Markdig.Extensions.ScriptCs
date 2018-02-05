namespace Markdig.Extensions.ScriptCs.ConsoleApp
{
    public static class StringConstants
    {
        public static string Header { get { return @"<!doctype html>
<html lang='en'>
<head>
    <meta charset='utf-8'>
    <title>Proof of concept</title>
    <meta name='description' content='Proof of concept'>
    <meta name='author' content='AntiFaffMarkdown'>
    <link href='https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css' rel='stylesheet'>
    <link rel='stylesheet' href='modest.css'>
    <link rel='stylesheet' href='style.css'>
    <!--[if lt IE 9]>
    <script src='https://cdnjs.cloudflare.com/ajax/libs/html5shiv/3.7.3/html5shiv.js'></script>
    <![endif]-->
</head>
<body>
<div class='container'>"; } }

        public static string Footer { get { return @"</div>
<script src='http://code.jquery.com/jquery-3.3.1.min.js' integrity='sha256-FgpCb/KJQlLNfOu91ta32o/NMZxltwRo8QtmkMRdAu8=' crossorigin='anonymous'></script>
<script src='https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js'></script>
</body>
</html>"; } }
    }
}
