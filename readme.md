<h2>
	MDS (Mutating Data Structure)
</h2>
<h4>
	Its a string , its a list , its an array , its a graph maybe , it can store almost 
	everything. Its mutating !!!!!!!!!!	<insert pixar studio screams>
</h4>
<br>
<h4>
	Why this data structure
</h4>
	I just wanted to try creating a string that is a collection . Thats the first idea. 
	And then i just thought , why not create a Datacontainer that represents different data in
	 strings , and the data can be of many types 
<br>
<br>
	Example , i can store an array of elements in one string 
<br>
<br>

	Or a list of different elements of different types in one single string , and be able to access it rapidly. 
	
<br>
<br>

	You can also easily change the mode of the datastructure to the specific kind of collection you want.
<br>
<br>

	Example : you can use Array mode [this is the standard mode of the datastructure] 
<br>
<br>
	or list mode [allows you to store different types of values]
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
