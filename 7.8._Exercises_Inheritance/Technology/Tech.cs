namespace Technology
{
    //Create an abstract intity to house the Id of each device.
    /*Abstract class design: Consider the group of classes that you designed. 
     * Suppose you have a web program that uses these classes and you need to 
     * assign a unique ID to every object created from them. Each class should 
     * have an id field, and no two objects created from any of the classes 
     * may have the same value for id. Create an abstract class, AbstractEntity, 
     * that contains the behavior for assigning and accessing such a unique ID 
     * for each class that extends it. Add this class to your Technology 
     * project above, and add AbstractEntity to the class hierarchy in the 
     * correct place.*/
    public abstract class Tech
    {
        int Id { get; set; }

        public abstract string PowerOn();


    }
}
