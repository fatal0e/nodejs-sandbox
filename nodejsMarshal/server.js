var edge = require('edge');

var dotNetFunction = edge.func('nodejsMarshal.dll');

var foo = 7;

var payload = {
	anInteger: foo,
	aNumber: 3.1415,
	aString: 'foo',
	aBoolean: true,
	aBuffer: new Buffer(10),
	anArray: [1, 'foo'],
	anObject: { a: 'foo', b: 12 }
};

dotNetFunction(payload, function (error, result) {
	if (error) throw error;
	console.log(result);
})