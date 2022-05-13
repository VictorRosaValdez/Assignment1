using Assignment1.Classes;
using System;
using Xunit;

namespace CharacterAttibuteAndLevelTests
{
    public class CharacterAttibuteAndLevelTests
    {
        #region A character is level 1 when created.
        /// <summary>
        /// When a character is created the default level is 1.
        /// </summary>
        [Fact]
        public void CreateNewCharacter_WithConstructor_DefaultLevel1()
        {
            // Arrange

            Character mage = new Mage("Mage");
            int expect = 1;

            // Act
            int actual = mage.CharacterLevel;
            // Assert
            Assert.Equal(expect, actual);
        }
        #endregion

        #region When a character gains a level, it should be level 2.
        /// <summary>
        /// When a character gains a level, it levels up to 2.
        /// </summary>
        /// 
        [Fact]
        public void IncreaseLevel_WhenGainsLevel_LevelShouldBe2()
        {
            // Arrange

            Character mage = new Mage("Mage");
            mage.IncreaseLevel();
            int expect = 2;

            // Act
            int actual = mage.CharacterLevel;
            // Assert
            Assert.Equal(expect, actual);

        }
        #endregion

        #region Each character class is created with the proper default attributes.

        /// <summary>
        /// Each character is created with the proper default attributes.
        /// Every character has a different deault attributes:
        /// A Mage begins at level 1 with: Strength 1, Dexterity 1, Intelligence 8.
        /// A Ranger begins at level 1 with: Strength 1, Dexterity 7, Intelligence 1.
        /// A Rouges begins at level 1 with: Strength 2, Dexterity 6, Intelligence 1.
        /// A Warrior begins at level 1 with: Strength 5, Dexterity 2, Intelligence 1.
        /// </summary>
        /// <param name="strength"></param>
        /// <param name="dexterity"></param>
        /// <param name="intelligence"></param>

        [Theory]
        [InlineData(1,1,8)]
        public void CreateNewCharacter_WithConstructor_DefaultAttributesMage_ShouldBe_10(int strength, int dexterity, int intelligence)
        {
            // Arrange
            Character mage = new Mage("Mage");
            int expect = 10;
            // Act
            int actual = mage.Strength + mage.Dexterity + mage.Intelligence;
            // Assert
            Assert.Equal(expect, actual);


        }

        [Theory]
        [InlineData(1, 7, 1)]
        public void CreateNewCharacter_WithConstructor_DefaultAttributesRanger_ShouldBe_9(int strength, int dexterity, int intelligence)
        {
            // Arrange

            Character ranger = new Ranger("Ranger");
            int expect = 9;
            // Act
            int actual = ranger.Strength + ranger.Dexterity + ranger.Intelligence;
            // Assert
            Assert.Equal(expect, actual);


        }

        [Theory]
        [InlineData(2, 6, 1)]
        public void CreateNewCharacter_WithConstructor_DefaultAttributesRouge_ShouldBe_9(int strength, int dexterity, int intelligence)
        {
            // Arrange

            Character rouge = new Rouge("Rouge");
            int expect = 9;
            // Act
            int actual = rouge.Strength + rouge.Dexterity + rouge.Intelligence;
            // Assert
            Assert.Equal(expect, actual);


        }

        [Theory]
        [InlineData(5, 2, 1)]
        public void CreateNewCharacter_WithConstructor_DefaultAttributesWarrior_ShouldBe_8(int strength, int dexterity, int intelligence)
        {
            // Arrange

            Character warrior = new Warrior("Warrior");
            int expect = 8;
            // Act
            int actual = warrior.Strength + warrior.Dexterity + warrior.Intelligence;
            // Assert
            Assert.Equal(expect, actual);


        }
        #endregion

        #region Each character class has their attributes increased when leveling up.
        /// <summary>
        /// Each character class has their attributes increased when leveling up.
        /// Every time a Mage levels up, they gain: Strength 1, Dexterity 1, Intelligence 5.
        /// Every time a Ranger levels up, they gain: Strength 1, Dexterity 5, Intelligence 1.
        /// Every time a Rouge levels up, they gain: Strength 1, Dexterity 4, Intelligence 1.
        /// Every time a Warrior levels up, they gain: Strength 3, Dexterity 2, Intelligence 1.
        /// </summary>
        /// <param name="strength"></param>
        /// <param name="dexterity"></param>
        /// <param name="intelligence"></param>
        [Theory]
        [InlineData(2, 2, 13)]
        public void IncreaseLevel_AttributesIncreased_Mage_ShouldBe_17(int strength, int dexterity, int intelligence)
        {
            // Arrange
            Character mage = new Mage("Mage");
            mage.IncreaseLevel();
            int expect = 17;
            // Act
            int actual = mage.Strength + mage.Dexterity + mage.Intelligence;
            // Assert
            Assert.Equal(expect, actual);


        }

        [Theory]
        [InlineData(2, 12, 2)]
        public void IncreaseLevel_AttributesIncreased_Ranger_ShouldBe_16(int strength, int dexterity, int intelligence)
        {
            // Arrange

            Character ranger = new Ranger("Ranger");
            ranger.IncreaseLevel();
            int expect = 16;
            // Act
            int actual = ranger.Strength + ranger.Dexterity + ranger.Intelligence;
            // Assert
            Assert.Equal(expect, actual);


        }

        [Theory]
        [InlineData(3, 10, 2)]
        public void IncreaseLevel_AttributesIncreased_Rouge_ShouldBe_15(int strength, int dexterity, int intelligence)
        {
            // Arrange

            Character rouge = new Rouge("Rouge");
            rouge.IncreaseLevel();
            int expect = 15;
            // Act
            int actual = rouge.Strength + rouge.Dexterity + rouge.Intelligence;
            // Assert
            Assert.Equal(expect, actual);


        }

        [Theory]
        [InlineData(8, 4, 2)]
        public void IncreaseLevel_AttributesIncreased_Warrior_ShouldBe_14(int strength, int dexterity, int intelligence)
        {
            // Arrange

            Character warrior = new Warrior("Warrior");
            warrior.IncreaseLevel();
            int expect = 14;
            // Act
            int actual = warrior.Strength + warrior.Dexterity + warrior.Intelligence;
            // Assert
            Assert.Equal(expect, actual);


        }
        #endregion
    }
}
