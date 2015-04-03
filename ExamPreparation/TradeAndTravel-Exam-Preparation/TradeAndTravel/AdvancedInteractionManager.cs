namespace TradeAndTravel
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class AdvancedInteractionManager : InteractionManager
    {
        public AdvancedInteractionManager()
            : base()
        {

        }
        protected override Item CreateItem(string itemTypeString, string itemNameString, Location itemLocation, Item item)
        {
            switch (itemTypeString)
            {
                case "weapon":
                    item = new Weapon(itemNameString, itemLocation);
                    break;
                case "wood":
                    item = new Wood(itemNameString, itemLocation);
                    break;
                case "iron":
                    item = new Iron(itemNameString, itemLocation);
                    break;
                default:
                    return base.CreateItem(itemTypeString, itemNameString, itemLocation, item);
            }
            return item;
        }

        protected override Location CreateLocation(string locationTypeString, string locationName)
        {
            Location location = null;
            switch (locationTypeString)
            {
                case "mine":
                    location = new Mine(locationName);
                    break;
                case "forest":
                    location = new Forest(locationName);
                    break;
                default:
                    return base.CreateLocation(locationTypeString, locationName);
            }
            return location;
        }

        protected override Person CreatePerson(string personTypeString, string personNameString, Location personLocation)
        {
            Person person = null;
            switch (personTypeString)
            {
                case "merchant":
                    person = new Merchant(personNameString, personLocation);
                    break;
                default:
                    return base.CreatePerson(personTypeString, personNameString, personLocation);
            }
            return person;
        }

        protected override void HandlePersonCommand(string[] commandWords, Person actor)
        {
            switch (commandWords[1])
            {
                case "gather":
                    HandleGatherInteraction(commandWords[2], actor);
                    break;
                case "craft":
                    HandleCraftInteraction(commandWords[2], commandWords[3], actor);
                    break;
                default:
                    base.HandlePersonCommand(commandWords, actor);
                    break;
            }
            
        }

        private void HandleCraftInteraction(string itemType, string craftedItemName, Person actor)
        {
            List<Item> items = actor.ListInventory();

            if (itemType == "weapon")
            {
                var canCreateWeapon = items.Any(i => i.ItemType == ItemType.Wood && items.Any(ii => ii.ItemType == ItemType.Iron));

                if (canCreateWeapon)
                {
                    this.AddToPerson(actor, new Weapon(craftedItemName, actor.Location));
                }
            }
            else if (itemType == "armor")
            {
                var canCreateArmor = items.Any(i => i.ItemType == ItemType.Iron);

                if (canCreateArmor)
                {
                    this.AddToPerson(actor, new Armor(craftedItemName, actor.Location));
                }
            }
        }

        private void HandleGatherInteraction(string gatheredItemName, Person actor)
        {
            List<Item> items = actor.ListInventory();

            if (actor.Location is IGatheringLocation)
            {
                var location = actor.Location as IGatheringLocation;

                if (location is Forest)
                {
                    var canGatherWood = items.Any(i => i.ItemType == location.RequiredItem);

                    if (canGatherWood)
                    {
                        this.AddToPerson(actor, location.ProduceItem(gatheredItemName));
                    }
                }
                else
                {
                    var canGatherIron = items.Any(i => i.ItemType == location.RequiredItem);

                    if (canGatherIron)
                    {
                        this.AddToPerson(actor, location.ProduceItem(gatheredItemName));
                    }
                }
            }

            //var gatherWood = items.Any(i => i.ItemType == ItemType.Weapon) && actor.Location.LocationType == LocationType.Forest;
            //var gatherIron = items.Any(i => i.ItemType == ItemType.Armor) && actor.Location.LocationType == LocationType.Mine;

            //if (gatherWood)
            //{
            //    this.AddToPerson(actor, new Wood(gatheredItemName, actor.Location));
            //}

            //if (gatherIron)
            //{
            //    this.AddToPerson(actor, new Iron(gatheredItemName, actor.Location));
            //}
        }
    }
}
