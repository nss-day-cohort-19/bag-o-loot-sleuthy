using System;
using System.Collections.Generic;
using Xunit;

namespace BagOLoot
{
    public class SantaHelperShould
    {
        SantaHelper _helper;
        public SantaHelperShould()
        {
            _helper = new SantaHelper();
        }
    // Items can be added to bag, and assigned to a child.
    [Fact]
    public void AddToyToChildsBag()
    {
        string toyName = "Skateboard";
        int childId = 715;
        int toyId = _helper.AddToyToBag(toyName, childId);
        List<int> toys = _helper.GetChildsToys(childId);

        Assert.Contains(toyId, toys);
    }

    // Items can be removed from bag, per child. Removing Ball, for example, from the bag should not be allowed. A child's name must be specified.
    [Fact]
    public void RemoveToyFromChildsBag()
    {
        int childId = 715;
        int toyId = 10;
        _helper.RemoveToyFromBag(toyId, childId);
        List<int> toys = _helper.GetChildsToys(childId);

        Assert.DoesNotContain(toyId, toys);
    }
    // Must be able to list all children who are getting a toy.
    [Fact]
    public void ListOfChildrenGettingToy()
    {
        List <string> AllChildrenGettingToy = _helper.GetAllChildrenGettingToy();

        Assert.IsType<List<string>> (AllChildrenGettingToy);
    }

    // Must be able to list all toys for a given child's name.
    [Fact]
    public void ListOfAllToysForSpecificChild()
    {
        int childId = 715;
        List <int> AllToysForSpecificChild = _helper.GetAllToysForSpecificChild(childId);

        Assert.IsType <List<int>> (AllToysForSpecificChild);
    }

    // Must be able to set the delivered property of a child, which defaults to false to true.
    [Fact]
    public void SetDeliveryStatusForChild()
    {
        int childId = 715;
        bool deliveryStatus = _helper.WasToyDelivered(childId);

        Assert.True (deliveryStatus);
    }
}
}