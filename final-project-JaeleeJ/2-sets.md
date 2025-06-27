# Sets

![set photo](https://images.twinkl.co.uk/tw1n/image/private/t_630/u/ux/set-of-fruits_ver_1.jpg)

Similar to lists, stacks, and queues, sets hold items. Unlike other data structures, the order of the data in a set is not important. There are no duplicates in a set which makes this data structure very efficient to determine if data is in the set. This is done with hashing. 

### Why use sets?
Sets are very efficient in its operations. With a set, developers can find unique values in a list, quickly access the unique values, and perform mathematical set operations (intersection and union). All of its operations have O(1) performance. This is due to the following reasons:
1. There are no duplicates in a set
2. The data in the set is not ordered

## Hashing Function
Hashing functions calculate an integer value based on the data. Hashing finds the index of the value. We can use the formula `value.GetHashCode()` to get the hash code value. Many data types can be applied to the formula to return the hash code. The value can be an integer, string, float, bool, or list.

## Open Addressing and Chaining
You might be wondering, "What if I have two elements that hash to the same location?" When this happens, there are two ways to solve the problem. The first way is called **open addressing**. This is when we use the `index(n)` hashing function to find whether there is an element already in a location. If there is, the open addressing strategy will say to move to the next open space in the sparse array. 

The second way is called **chaining**. While open addressing finds an open place for data, chaining lets the values share a space. In chaining, we can make a list of values that are in the same location. These options keep the O(1) performance of sets. 

## Common Operations
Operation | Efficiency | Description 
----------|------------|-------------
Add(value) | O(1) | Add a value
Remove(value) | O(1) | Remove a value 
Contains(value) | O(1) | Determine if value is present
Count | O(1) | Count the number of items

## Example
Below is a simple example of how to use some of the common operations in code: 

```csharp
public static void Main() {
    // create a set
    var data = new HashSet<int>(new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 });

    // if 21 is not in the set, add it to the set
    if (!data.Contains(21)){
        data.Add(21);
    }

    // if 5 is in the set, remove it from the set
    if (data.Contains(5)){
        data.Remove(5);
    }

    // print the set and how many elements there are inside
    Console.WriteLine(data);
    Console.WriteLine($"There are {data.Count} elements in the data set.")

}

```

## Problem to Solve: Holiday Barbie Doll Set
![Barbie Photo](https://i.ytimg.com/vi/v1M9M8BPl5Q/maxresdefault.jpg)
You have a set of the Special Edition Holiday Barbie dolls. In a set, you have listed each of the dolls that you own. Edit the set according to the recent changes in your collection:

### Requirements:
1. You bought this year's Holiday Barbie to add to the list
2. Your sister accidentally sold your 2015 Holiday Barbie doll, so you no long have it in your collection

After making changes to your set, you are curious about the contents. You know that you have many dolls, but not the exact amount and which ones are present in your set.

3. Find out how many Holiday Barbies you have in your collection
4. Determine whether you have the 2016 Special Edition Holiday Barbie


Below, you will find the starter code with your current set of Barbies:
```csharp
public static class Program
{

    public static void Main()
    {
        var barbies = new HashSet<string>(new[] {"1995", "2000", "2014", "2013", "2005", "2010", "1999", 
            "1998", "2015", "2011", "2012", "2002", "2006", "2007", "1996", "2018", "2009", "2004", "1992", "2021", 
            "2020", "2019", "1994", "2016", "2001", "2014" });

        // add this year's Barbie
        
        
        // remove the 2015 doll
        

        // find out how many barbies are in the set
        
        
        // determine whether you have the 2016 Special Edition Holiday Barbie
       
    }
}

```


See the solution here: [Solution](sets-problem-solution)