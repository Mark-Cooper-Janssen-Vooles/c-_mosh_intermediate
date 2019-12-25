### PRoperties

A class member that encapsulates a getter/setter for accessing a field.

Why? 
To create a getter/setter with less code. 

public class Person
{
  private DateTime _birthdate;

  public void SetBirthdate(DateTime birthdate)
  {
    this._birthdate = birthdate;
  }

  public DateTime GetBirthdate()
  {
    return this._birthdate;
  }
}

Convert this using properties: 

public class Person
{
  private DateTime _birthdate;

  public DateTime Birthdate
  {
    get { return this._birthdate; }
    set { _this.birthdate = value; }
  }
}


***Declaring an auto-implemented property:***

public class Person
{
  public DateTime Birthdate { get; set; }
}

//when c# sees the above, internally it creates a private field for us so we don't have to do that. 

internally creates a private field and implements get and set accessors for us.

shortcut: 
type "prop" in VS and press tab.

convention is to put all properties on the top! 