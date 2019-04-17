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
        public int Count { get; set; }


        public void Deserialize(DeserializeEvent e)
        {
            ID = e.Reader.ReadInt32();
            ItemID = e.Reader.ReadInt32();
            Position = e.Reader.ReadInt32();
            Count = e.Reader.ReadInt32();

        }

        public void Serialize(SerializeEvent e)
        {
            e.Writer.Write(ID);
            e.Writer.Write(ItemID);
            e.Writer.Write(Position);
            e.Writer.Write(Count);
 
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

    public class GetInventoryServerDTO : IDarkRiftSerializable
    {
        public int InventoryID { get; set; }
        public int Size { get; set; }
        public InventoryItemDTO[] InventoryItems { get; set; }

        public void Deserialize(DeserializeEvent e)
        {
            InventoryID = e.Reader.ReadInt32();
            Size = e.Reader.ReadInt32();
            InventoryItems = e.Reader.ReadSerializables<InventoryItemDTO>();
        }

        public void Serialize(SerializeEvent e)
        {
            e.Writer.Write(InventoryID);
            e.Writer.Write(Size);
            e.Writer.Write(InventoryItems);
        }
    }

    public class TransferItemClientDTO : IDarkRiftSerializable
    {
        public int InventoryItemID { get; set; }
        public int SourceInventoryID { get; set; }
        public int DestinationInventoryID { get; set; }
        public int Position { get; set; }

        public void Deserialize(DeserializeEvent e)
        {
            InventoryItemID = e.Reader.ReadInt32();
            SourceInventoryID = e.Reader.ReadInt32();
            DestinationInventoryID = e.Reader.ReadInt32();
            Position = e.Reader.ReadInt32();
        }

        public void Serialize(SerializeEvent e)
        {
            e.Writer.Write(InventoryItemID);
            e.Writer.Write(SourceInventoryID);
            e.Writer.Write(DestinationInventoryID);
            e.Writer.Write(Position);
        }
    }

    class TransferItemServerDTO : IDarkRiftSerializable
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public TransferItemClientDTO data { get; set; }
        
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

    class ItemDTO : IDarkRiftSerializable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ushort EntityID { get; set; }

        public void Deserialize(DeserializeEvent e)
        {
            Id = e.Reader.ReadInt32();
            Name = e.Reader.ReadString();
            EntityID = e.Reader.ReadUInt16();
        }

        public void Serialize(SerializeEvent e)
        {
            e.Writer.Write(Id);
            e.Writer.Write(Name);
            e.Writer.Write(EntityID);
        }
    }


}
