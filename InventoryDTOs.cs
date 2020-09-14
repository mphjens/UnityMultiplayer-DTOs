using DarkRift;

using System;
using System.Collections.Generic;
using System.Text;

namespace UnityMultiplayerDRPlugin.DTOs
{

    public class InventoryItemDTO : IDarkRiftSerializable
    {

        public int ID { get; set; }

        public int ItemID { get; set; }
        public int Position { get; set; }
        public int Quantity { get; set; }

        public int InventoryID { get; set; }

        public void Deserialize(DeserializeEvent e)
        {
            ID = e.Reader.ReadInt32();
            ItemID = e.Reader.ReadInt32();
            Position = e.Reader.ReadInt32();
            Quantity = e.Reader.ReadInt32();

        }

        public void Serialize(SerializeEvent e)
        {
            e.Writer.Write(ID);
            e.Writer.Write(ItemID);
            e.Writer.Write(Position);
            e.Writer.Write(Quantity);
 
        }
    }

    public class GetInventoryClientDTO : IDarkRiftSerializable
    {
        public int InventoryID { get; set; }

        public void Deserialize(DeserializeEvent e)
        {
            InventoryID = e.Reader.ReadInt32();
        }

        public void Serialize(SerializeEvent e)
        {
            e.Writer.Write(InventoryID);
        }
    }

    public class InventoryDTO : IDarkRiftSerializable
    {
        public int Id { get; set; }
        public int Size { get; set; }

        public void Deserialize(DeserializeEvent e)
        {
            Id = e.Reader.ReadInt32();
            Size = e.Reader.ReadInt32();
        }

        public void Serialize(SerializeEvent e)
        {
            e.Writer.Write(Id);
            e.Writer.Write(Size);
        }
    }

    public class GetInventoryServerDTO : IDarkRiftSerializable
    {
        public InventoryDTO Inventory;
        public InventoryItemDTO[] InventoryItems { get; set; }

        public void Deserialize(DeserializeEvent e)
        {
            Inventory = e.Reader.ReadSerializable<InventoryDTO>();
            InventoryItems = e.Reader.ReadSerializables<InventoryItemDTO>();
        }

        public void Serialize(SerializeEvent e)
        {
            e.Writer.Write(Inventory);
            e.Writer.Write(InventoryItems);
        }
    }

    public class TransferItemClientDTO : IDarkRiftSerializable
    {
        public int InventoryItemID { get; set; }
        public int DestinationInventoryID { get; set; }
        public int Position { get; set; }

        public void Deserialize(DeserializeEvent e)
        {
            InventoryItemID = e.Reader.ReadInt32();
            DestinationInventoryID = e.Reader.ReadInt32();
            Position = e.Reader.ReadInt32();
        }

        public void Serialize(SerializeEvent e)
        {
            e.Writer.Write(InventoryItemID);
            e.Writer.Write(DestinationInventoryID);
            e.Writer.Write(Position);
        }
    }

    class SubscribeInventoryClientDTO : IDarkRiftSerializable
    {
        public int InventoryID;
        public bool Subscribe; //We try to unsub when false

        public void Deserialize(DeserializeEvent e)
        {
            InventoryID = e.Reader.ReadInt32();
            Subscribe = e.Reader.ReadBoolean();
        }

        public void Serialize(SerializeEvent e)
        {
            e.Writer.Write(InventoryID);
            e.Writer.Write(Subscribe);
        }
    }

    class SubscribeInventoryServerDTO : IDarkRiftSerializable
    {
        public bool Success;
        public int InventoryID;

        public void Deserialize(DeserializeEvent e)
        {
            Success = e.Reader.ReadBoolean();
            InventoryID = e.Reader.ReadInt32();
        }

        public void Serialize(SerializeEvent e)
        {
            e.Writer.Write(Success);
            e.Writer.Write(InventoryID);
        }
    }

    class TransferItemServerDTO : IDarkRiftSerializable
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public TransferItemClientDTO data { get; set; }

        public TransferItemServerDTO()
        {
            Message = "";

        }
        public void Deserialize(DeserializeEvent e)
        {
            Success = e.Reader.ReadBoolean();
            Message = e.Reader.ReadString();
            data = e.Reader.ReadSerializable<TransferItemClientDTO>();
        }

        public void Serialize(SerializeEvent e)
        {
            e.Writer.Write(Success);
            e.Writer.Write(Message);
            e.Writer.Write(data);
        }
    }

    class InventoryUpdateDTO : IDarkRiftSerializable
    {
        public int InventoryID { get; set; }
        public InventoryItemDTO[] Items { get; set; }


        public void Deserialize(DeserializeEvent e)
        {
            InventoryID = e.Reader.ReadInt32();
            Items = e.Reader.ReadSerializables<InventoryItemDTO>();
        }

        public void Serialize(SerializeEvent e)
        {
            e.Writer.Write(InventoryID);
            e.Writer.Write(Items);
        }
    }

    public class ItemDTO : IDarkRiftSerializable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ushort EntityID { get; set; }
        public float Value { get; set; }
        public ushort StackSize { get; set; }

        public void Deserialize(DeserializeEvent e)
        {
            Id = e.Reader.ReadInt32();
            Name = e.Reader.ReadString();
            Description = e.Reader.ReadString();
            EntityID = e.Reader.ReadUInt16();
            Value = e.Reader.ReadSingle();
            StackSize = e.Reader.ReadUInt16();
        }

        public void Serialize(SerializeEvent e)
        {
            e.Writer.Write(Id);
            e.Writer.Write(Name);
            e.Writer.Write(Description);
            e.Writer.Write(EntityID);
            e.Writer.Write(Value);
            e.Writer.Write(StackSize);
        }
    }

    public class GetItemsServerDTO : IDarkRiftSerializable
    {
        public ItemDTO[] Items;

        public void Deserialize(DeserializeEvent e)
        {
            Items = e.Reader.ReadSerializables<ItemDTO>();
        }

        public void Serialize(SerializeEvent e)
        {
            e.Writer.Write(Items);
        }
    }

    public class LoginAccountClientDTO : IDarkRiftSerializable
    {
        public string Username;

        public void Deserialize(DeserializeEvent e)
        {
            Username = e.Reader.ReadString();
        }

        public void Serialize(SerializeEvent e)
        {
            e.Writer.Write(Username);
        }
    }

    public class LoginAccountServerDTO : IDarkRiftSerializable
    {
        public bool Success;
        public AccountDataDTO Account;

        public void Deserialize(DeserializeEvent e)
        {
            Success = e.Reader.ReadBoolean();
            if(Success)
            {
                Account = e.Reader.ReadSerializable<AccountDataDTO>();
            }
        }

        public void Serialize(SerializeEvent e)
        {
            e.Writer.Write(Success);
            if (Success)
            {
                e.Writer.Write(Account);
            }
        }
    }

    public class LoginCharacterClientDTO : IDarkRiftSerializable
    {
        public int CharacterID;

        public void Deserialize(DeserializeEvent e)
        {
            CharacterID = e.Reader.ReadInt32();
        }

        public void Serialize(SerializeEvent e)
        {
            e.Writer.Write(CharacterID);
        }
    }

    public class LoginCharacterServerDTO : IDarkRiftSerializable
    {
        public bool Success;
        public CharacterDataDTO Character;

        public void Deserialize(DeserializeEvent e)
        {
            Success = e.Reader.ReadBoolean();
            Character = e.Reader.ReadSerializable<CharacterDataDTO>();
        }

        public void Serialize(SerializeEvent e)
        {
            e.Writer.Write(Success);
            if (Success)
            {
                e.Writer.Write(Character);
            }
            
        }
    }

    public class AccountDataDTO : IDarkRiftSerializable
    {
        public int Id { get; set; }
        public string Username { get; set; }

        public CharacterDataDTO[] Characters;

        public void Deserialize(DeserializeEvent e)
        {
            this.Id = e.Reader.ReadInt32();
            this.Username = e.Reader.ReadString();
            this.Characters = e.Reader.ReadSerializables<CharacterDataDTO>();
        }

        public void Serialize(SerializeEvent e)
        {
            e.Writer.Write(Id);
            e.Writer.Write(Username);
            e.Writer.Write(Characters);
        }
    }

    public class CharacterDataDTO : IDarkRiftSerializable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int InventoryID { get; set; }
        public byte Level { get; set; }
        public float Experience { get; set; }
        public int Money { get; set; }


        public void Deserialize(DeserializeEvent e)
        {
            this.Id = e.Reader.ReadInt32();
            this.Name = e.Reader.ReadString();
            this.InventoryID = e.Reader.ReadInt32();
            this.Level = e.Reader.ReadByte();
            this.Experience = e.Reader.ReadSingle();
            this.Money = e.Reader.ReadInt32();
        }

        public void Serialize(SerializeEvent e)
        {
            e.Writer.Write(Id);
            e.Writer.Write(Name);
            e.Writer.Write(InventoryID);
            e.Writer.Write(Level);
            e.Writer.Write(Experience);
            e.Writer.Write(Money);
        }
    }


}
