### Indexer

A way to access elements in a class that represents a list of values. 

var array = new int[5];
array[0] = 1;

var list = new List<int>();
list[0] = 1;


---

Example: 

var cookie = new HttpCookie();
cookie.Expire = DateTime.Today.AddDays(5);

//using the indexer to set:
cookie["name"] = "Mark";
//without an indexer, achieves the same thing but longer: 
cookie.SetItem("name", "Mark");

//save the indexer (i.e. get):
var name = cookie["name"];
//save the indexer using get item: 
var name = cookie.GetItem("name");


---

An indexer is nothing but a property. 
Can can declare an indexer the same way as a property. 

public class HttpCookie
{
  public string this[string key]
  {
    get { ... }
    set { ... }
  }
}

instead of identifier, you use the "this" keyword and the indexer notation. 




dictionary is the data type, uses a hash table to store data. Fast to lookup an item by its key (a list of objects looked up by a key, i.e. a string or something).

if you have a list of objects to be looked up by an index, then just a list. 

---

Take away:
If you're working with a class that has the semantics of a collection, list, or dictionary, you can improve your code by declaring an indexer! 