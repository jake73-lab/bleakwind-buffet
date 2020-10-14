using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using Xunit;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class ComboTests
    {
        [Fact]
        public void ChangingDrinkNotifiesDrinkProperty()
        {
            AretinoAppleJuice drink = new AretinoAppleJuice();
            BriarheartBurger entree = new BriarheartBurger();
            DragonbornWaffleFries side = new DragonbornWaffleFries();

            Combo combo = new Combo(drink, entree, side);

            Assert.PropertyChanged(combo, "drink", () =>
            {
                SailorSoda newDrink = new SailorSoda();
                combo.drink = newDrink;
            });
        }

        [Fact]
        public void ChangingEntreeNotifiesEntreeProperty()
        {
            AretinoAppleJuice drink = new AretinoAppleJuice();
            BriarheartBurger entree = new BriarheartBurger();
            DragonbornWaffleFries side = new DragonbornWaffleFries();

            Combo combo = new Combo(drink, entree, side);

            Assert.PropertyChanged(combo, "entree", () =>
            {
                ThalmorTriple newEntree = new ThalmorTriple();
                combo.entree = newEntree;
            });
        }

        [Fact]
        public void ChangingSideNotifiesSideProperty()
        {
            AretinoAppleJuice drink = new AretinoAppleJuice();
            BriarheartBurger entree = new BriarheartBurger();
            DragonbornWaffleFries side = new DragonbornWaffleFries();

            Combo combo = new Combo(drink, entree, side);

            Assert.PropertyChanged(combo, "side", () =>
            {
                MadOtarGrits newSide = new MadOtarGrits();
                combo.side = newSide;
            });
        }

        [Fact]
        public void ShouldReturnCorrectCaloriesForMeal()
        {
            AretinoAppleJuice drink = new AretinoAppleJuice();
            BriarheartBurger entree = new BriarheartBurger();
            DragonbornWaffleFries side = new DragonbornWaffleFries();

            Combo combo = new Combo(drink, entree, side);
            uint total = drink.Calories + entree.Calories + side.Calories;
            Assert.Equal(total, combo.Calories);
        }

        [Fact]
        public void ShouldReturnCorrectPriceForMeal()
        {
            AretinoAppleJuice drink = new AretinoAppleJuice();
            BriarheartBurger entree = new BriarheartBurger();
            DragonbornWaffleFries side = new DragonbornWaffleFries();

            Combo combo = new Combo(drink, entree, side);
            double total = drink.Price + entree.Price + side.Price;
            Assert.Equal(total, combo.Price);
        }
    }
}
