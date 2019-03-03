using DarkRift;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnityMultiplayerDRPlugin.DTOs
{
    class DamageHurtableClientDTO : IDarkRiftSerializable
    {
        public ushort VictimID;
        public float damage;
        

        public void Deserialize(DeserializeEvent e)
        {
            VictimID = e.Reader.ReadUInt16();
            damage = e.Reader.ReadSingle();
        }

        public void Serialize(SerializeEvent e)
        {
            e.Writer.Write(VictimID);
            e.Writer.Write(damage);            
        }
    }
}
