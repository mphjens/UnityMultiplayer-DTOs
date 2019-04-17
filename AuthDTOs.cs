using DarkRift;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnityMultiplayerDRPlugin.DTOs
{
    public class LoginClientDTO : IDarkRiftSerializable
    {
        public string username { get; set; }

        public void Deserialize(DeserializeEvent e)
        {
            username = e.Reader.ReadString();
        }

        public void Serialize(SerializeEvent e)
        {
            e.Writer.Write(username);
        }
    }

    public class LoginServerDTO : IDarkRiftSerializable
    {
        public bool Success { get; set; }
        public string Message { get; set; } = "";
        public AuthUserDTO User { get; set; }

        public void Deserialize(DeserializeEvent e)
        {
            Success = e.Reader.ReadBoolean();
            Message = e.Reader.ReadString();
            User = e.Reader.ReadSerializable<AuthUserDTO>();
        }

        public void Serialize(SerializeEvent e)
        {
            e.Writer.Write(Success);
            e.Writer.Write(Message);
            e.Writer.Write(User);
        }
    }

    public class AuthUserDTO : IDarkRiftSerializable
    {
        public int Id { get; set; }
        public string Username { get; set; } = "";
        public int InventoryId { get; set; }


        public void Deserialize(DeserializeEvent e)
        {
            Id = e.Reader.ReadInt32();
            Username = e.Reader.ReadString();
            InventoryId = e.Reader.ReadInt32();
        }

        public void Serialize(SerializeEvent e)
        {
            e.Writer.Write(Id);
            e.Writer.Write(Username);
            e.Writer.Write(InventoryId);
        }
    }

}
