<h2>
	MDS (Mutating Data Structure)
</h2>
<br>
<h4>
	Its a string , its a list , its an array , its a graph maybe , it can store almost 
	everything. Its mutating !!!!!!!!!!	<insert pixar studio screams>
</h4>
<br>
<h4>
	Why this data structure
</h4>
<br>
	I just wanted to try creating a string that is a collection . Thats the first idea. 
<br>

<code>

	int A = 7;
	int B = 8;

	Mds.Ucont myArray = new Mds.Ucont();		// create instance of ucont container.

	myArray.AddElement(A);				// add the element to the array.
	myArray.AddElement(B);

	myArray.RemoveElement(index:1);			// remove the element on the passed index.

	string C = myArray.GetElement(index:0);		// get the element from the container as a string.
	
</code>
