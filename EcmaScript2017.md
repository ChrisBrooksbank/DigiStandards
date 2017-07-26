# ES2017 ( ES 8 )
Roland Guijt PluralSight Course

Already implemented in latest browsers

Brendan Eich

ES = EcmaScript
Committee. 2009 = V5. 2015 = V6 (ES 2015) 
=> one version per year, year in name.
Five stages to release ( Strawman => Proposal => Draft => Candidate => Finished )

Proxys ( ES2015 feature 
)gitAsynch

Old browsers : Transpile, Polyfills, Simulate, not possible => Babel, babel-polyfill
(Babel installation/config demo )

Array.prototype.includes and exponentiation operator => ES2016

#ES2015 [more information](https://themeteorchef.com/blog/what-is-es2015)

##Arrow Functions
Are a more concise syntax for writing function expressions. 
var multiply = (x, y) => x*y;

## let
let allows you to declare variables that are limited in scope to the block, statement, or expression on which it is used. 

This is unlike the var keyword, which defines a variable globally, or locally to an entire function regardless of block scope.

## const

## Template Strings

## Classes
Primarily syntactical sugar over JavaScript's existing prototype-based inheritance. 

```JavaScript
class Rectangle {
  constructor(height, width) {
    this.height = height;
    this.width = width;
  }
}
```

e.t.c. e.g. generators, destructurors ...

#ES2016

## Array.prototype.includes
Check if array contains a specified value, returns true or false, replaces use of indexOf ( where return of -1 meant not there). Also works on "Array Like" objects.

## Exponentiation Operator
** replaces use of Math.pow()

That was it for ES2016 additions !

#ES2017 [More Information](https://medium.com/komenco/what-to-expect-from-javascript-es2017-the-async-edition-618e28819711)

## Asynch functions

### callbacks
callbacks => promises => asynch & await

callback. old school. pass in function as param to enable control flow to it on completion.
downsides : error handling makes code increasingly unreadable

### promises ( ES2015 )
promises enable seperation of processing from workflow.
A promise is a placeholder object for eventual result.

Promise states : Pending, Fulfilled, Rejected ( something went wrong )

Promises are chainable.

```JavaScript
fetchrides().then( rides => {
	// process rides
})
```

fetchrides() is not responbsible for calling a callback function.

```JavaScript
function fetchRides( ){
	return new Promise( (resolve,reject) => {
	  //get rides from server e.g. with XmlHttpRequest
	  resolve(rides);
	  //if error
	  reject(errorInfo);
	} );
}
```

You can chain functions together when they return promises, with .then().then.then().catch();

Can also capture promise into a var, pass into another function, and in there attach thens.

Promise.all(), done when all supplied promises done

Promise.race(), done when faster promise done, optionally only returning result from that promise

## async

Add the async keyword to a function declaration.
Everything you return from that function will be wrapped in a resolved promise.

```JavaScript
var return123 = async () => { 
return 123; 
}

return123().then( result => {
	console.log(result);
}).catch( result => {
	comsole.log(result)
});
```

## await

Add this keyword to a call to any function that returns a promise.
It can only be written INSIDE a async function.

Code below the call is made when the code in the promise has finished.

Await automatically pulls the result out of the promise.

## Sequential vs Parallel

If you dont need result, have fire and forget, can run without await, in parallel.
await Promise.all() instead.

## Promisfying

e.g. for httpRequest(method,url)
return a Promise

## Shared array buffers

Refresher : Web workers
Runs tasks in parallel, part of HTML5 spec, implemented by Browsers.
Each worker has its own global environment/

```JavaScript
let worker = new Worker("someTask.js");
worker.postMessage(workOnThisData); // sends some data to the worker
worker.onMessage = (event) => {
	// process data posted back by worker in event.data
}
```

inside worker : 

```JavaScript
self.addEventListener('message#, ( even => {
  // gete event data == posted data by main thread
  // process data

  self.postMessage(processedData);
})
```

Cant share memory, so postmessage does structured cloning of object.

Transferables

Refresher : arrayBuffer and typed arrays.

SharedArrayBuffer lets multiple workers work on same data at same time.

ArrayBuffer and Typed Arrays => binary data
JavaScript typed arrays are array-like objects and provide a mechanism for accessing raw binary data

JavaScript typed arrays split the implementation into buffers and views. A buffer (implemented by the ArrayBuffer object) is an object representing a chunk of data; it has no format to speak of, and offers no mechanism for accessing its contents. In order to access the memory contained in a buffer, you need to use a view. A view provides a context — that is, a data type, starting offset, and number of elements — that turns the data into an actual typed array.

## Atomics



