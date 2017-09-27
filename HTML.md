# HTML
* Must include a favicon, e.g. in _layout.cshtml
	<link rel="shortcut icon" href="/Content/img/favicon.ico" type="image/x-icon" /> 
* Use Labels where appropiate ( dont just spans ) 
  * Labels must have for attribute, so that clicking on label selects DOM element
  * e.g. use helper methods such as : @Html.LabelFor(model => model.SelectedPage, "Show") 
