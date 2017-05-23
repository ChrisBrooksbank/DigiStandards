# DigiStandards

## Code
* Ensure there are no unneeded using clauses ( grey )
* Always define variables as type var
* No spaces immeditely before or after brackets
* Define new Attribute descendants where appropiate e.g. to encode data relating to a enumeration value
* When a partial needs its own Model, use @Html.Action()
	* Decorate the action with [ChildActionOnly] assuming you dont want to be able to hit endpoint by hitting its URL
	* This action can return Partial e.g.  return PartialView("_Navigation", model);
* Use Extension methods e.g. to format dates in different ways or to interact with Enums	
* Inject services into Controller constructors 

## HTML
* Use Labels where appropiate ( not just spans ) e.g. @Html.LabelFor(model => model.SelectedPage, "Show")

## JavaScript
* Consider appropiate plugins depending on project/techs 
	* e.g. NiceSelect which makes a select list look like a animated dropdown menu
* 	

## Styling Visual

## Styling SCSS
* scss should use nesting, rather than having a list of selectors
* & means and, > means descendant
* First { should be on same line as selector
* Final } on its own line
* Use [ColorSchemer](http://www.colorschemer.com/online.html) to generate a darker colour to use on a hover
* Look for free ( check licence ) SVGS [here](http://simpleicon.com/), only when bootstrap glyphs not available. Otherwise IPhones need high quality imahes.
* margin auto is a way to horizontally centre a block element. e.g. margin : 0 auto 0 auto; analgous to text-align centre
* If a css rule isnt applied, because another rule takes precendance Increase the rules selector specifity
* Dont use !important
* If a element is being truncated, check its display is set to block rather than inline
* Remember selectors such as : first-of-type, nth-Child
* Buttons style differently. To make a really wide button display: block; doesnt work, width: 100% should


## Chrome Devtools
* On the elements tab, in Chrome Devtools, there are several tabs. Styles, Computed, Event Listeners, DOM Breakpoints, Properties
* Computed shows the element and displays the values of its padding, border and margin.
* 
