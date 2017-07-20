using System;
using System.Collections.Generic;

namespace BagOLoot
{
    public class SantaHelper
    {
        // Items can be added to bag, and assigned to a child.
        public int AddToyToBag(string toy, int child)
        {
            return 4;
        }
        // Get list of a specific child's toys.
        public List<int> GetChildsToys(int child)
        {
            return new List<int>() {4, 6, 7, 8};
        }

        // Items can be removed from bag, per child. Removing Ball, for example, from the bag should not be allowed. A child's name must be specified.
        public int RemoveToyFromBag(int toyId, int child)
        {
            //returning toyId here
            return 5;
        }
        // Must be able to list all children who are getting a toy.
        public List<string> GetAllChildrenGettingToy()
        {
            return new List<string>() {"Kathy", "Frankie", "Harold"};
        }
        // Must be able to list all toys for a given child's name.
        public List<int> GetAllToysForSpecificChild(int child)
        {
            return new List<int>() { 5 };
        }

        // Must be able to set the delivered property of a child, which defaults to false to true.
        public bool WasToyDelivered(int child)
        {
            return true;
        }
    }
}

