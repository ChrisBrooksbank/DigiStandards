# Styling SCSS

## CheckList
* scss should use nesting, rather than having a list of selectors
* & means and, > means descendant
* First { should be on same line as selector
* Final } on its own line
* Use [ColorSchemer](http://www.colorschemer.com/online.html) to generate a darker colour to use on a hover
* Look for free ( check licence ) SVGS [here](http://simpleicon.com/), only when bootstrap glyphs not available. Otherwise IPhones need high quality imahes.
* margin auto is a way to horizontally centre a block element. e.g. margin : 0 auto 0 auto; analgous to text-align centre
* If a css rule isnt applied, because another rule takes precendance Increase the rules selector specifity
* Dont use !important, unless essential
* If a element is being truncated, check its display is set to block rather than inline
* Remember selectors such as : first-of-type, nth-Child
* Buttons style differently. To make a really wide button display: block; doesnt work, width: 100% should

## Mobile First
The styling for mobile phones should be at the top of the file, with no media query.

The styling for desktops should be later in the file, with a media query.
e.g. :

```css
@media (min-width: $screen-md-min) {
    .navbar {
        &.navbar-primary {
            .page-election-navigation {
                height:auto;
                float: right;
                margin-top: 3px;
```
