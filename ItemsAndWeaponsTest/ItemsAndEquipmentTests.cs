using System;
using Xunit;
using Assignment1.Classes;
using Assignment1.Custom_Exceptions;

namespace ItemsAndEquipmentTests
{
    public class ItemsAndEquipmentTests
    {

        #region If a character tries to equip the wrong weapon type Invalid exception should be thrown.

        /// <summary>
        ///  Check if the character can use the weapon. The name of the weapon has to be identical to the enumtype. 
        /// </summary>
        /// <returns>String that the character can or can not use the weapon.</returns>
        [Fact]
       
        public void NotAllowedForCharacter_ShouldThrownException()
        {
            // Arrange

            Item weapon = new Weapon();
            string expect = "Warrior can not use this weapon";
            string result = weapon.NotAllowedForCharacter("Warrior", "Bows");
            // Act
            string actual = result;
            // Assert
            Assert.Equal(expect, actual);
        }
        #endregion

        #region If a character tries to equip the wrong armor type Invalid exception should be thrown.
        /// <summary>
        /// Check if the character can use the armor. The name of the armor has to be identical to the enumtype. 
        /// </summary>
        /// <returns>String that the character can or can not use the armor.</returns>
        [Fact]
        public void NotAllowedForCharacter_Armor_ShouldThrownException()
        {
            // Arrange

            Item armor = new Armor();
            string expect = "Warrior can not use this Armor";
            string result = armor.NotAllowedForCharacter("Warrior", "Cloth");
            // Act
            string actual = result;
            // Assert
            Assert.Equal(expect, actual);
        }
        #endregion

        #region If a character equips a valid weapon, a success meassge should be returned.

        /// <summary>
        /// When a character equips a valid weapon, a success message is returned.
        /// Also a new weapon will be created.
        /// </summary>
        /// <returns>String: New weapon equipped or you can not add this weapon.</returns>

        [Fact]
        
        public void AddItem_Weapon_Success_Returned()
        {
            // Arrange

            Item weapon = new Weapon();
            string expect = "New weapon equipped!";
            string result = weapon.AddItem("Mage", "Staffs");
            // Act
            string actual = result;
            // Assert
            Assert.Equal(expect, actual);
        }
        #endregion

        #region If a character equips a valid armor, a success meassge should be returned.

        /// <summary>
        /// When a character equips a valid armor, a success message is returned.
        /// Also a new armor will be created.
        /// </summary>
        /// <returns>String: New armos equipped or you can not add this weapon.</returns>
        [Fact]
        public void AddItem_Success_Armor_Returned()
        {
            // Arrange

            Item armor = new Armor();
            string expect = "New armor equipped!";
            string result = armor.AddItem("Mage", "Cloth");
            // Act
            string actual = result;
            // Assert
            Assert.Equal(expect, actual);
        }
        #endregion

        #region Calculate damage if no weapon is equiped.
        /// <summary>
        /// Calculate the damage of a character when no weapon is equiped.
        /// </summary>
        /// <returns>Double:The value of damage that the character can do.</returns>
        [Fact]
        public void CharacterDamage_Warrior_Level1_WithoutWeapon_ShouldBe_105()
        {
            // Arrange

            Character warrior = new Warrior("Warrior");
            double expect = 1.05;
            warrior.CharacterDamage(1, false, false);
            // Act
            double actual = warrior.Damage;
            // Assert
            Assert.Equal(expect, actual);
        }
        #endregion

        #region Calculate damage with valid weapon equipped.
        /// <summary>
        /// Calculate the damage of a character with valid weapon equipped.
        /// </summary>
        /// <returns>Double:The value of damage that the character can do. </returns>
        [Fact]
        public void CharacterDamage_Warrior_Level1_WithWeapon_ShouldBe_8085()
        {
            // Arrange
            Character warrior = new Warrior("Warrior");
            double expect = 8.085;
            warrior.CharacterDamage(1, true, false);
            // Act
            double actual = warrior.Damage;
            // Assert
            Assert.Equal(expect, actual);
        }
        #endregion

        #region Calculate damage with valid weapon and armor equipped.
        /// <summary>
        /// Calculate damage with valid weapon and armor equipped.
        /// The character is in level 1.
        /// </summary>
        /// <returns>Double:The value of damage the character can do.</returns>
        [Fact]
        public void CharacterDamage_Warrior_Level1_WithWeaponAndAmor_ShouldBe_8162()
        {
            // Arrange
            Character warrior = new Warrior("Warrior");
            double expect = 8.162;
            warrior.CharacterDamage(1, true, true);
            // Act
            double actual = warrior.Damage;
            // Assert
            Assert.Equal(expect, actual);
        }
        #endregion

        #region Create Equipment
        [Fact]
        public void Constructor_InitializeWithSize_ShouldCreateEquipmentWithSize() 
        {
            // Arrange
            int size = 5;
            Equipment equipment = new Equipment(size);
            int expected = size;
            // Act
            int actual = equipment.GetEquipmentSize();
            // Assert
            Assert.Equal(expected, actual);
        
        }
        


        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void Constructor_InvalidSize_ShouldThrouwEquimentException(int size)
        {
            // Act and Assert
            Assert.Throws<EquipmentException>(() => new Equipment(size));
        }
        #endregion

      
    }
}
