using Assets.DTOs;
using DarkRift;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnityMultiplayerDRPlugin.DTOs
{
    public class UMVector3
    {
        public float x, y, z;
        public UMVector3(float x, float y , float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }

    class SpawnProceduralShapeEntityServerDTO : IDarkRiftSerializable
    {
        public uint ID;
        public ProceduralEntityType type;
        public UMVector3 position;
        public UMVector3 rotation;
        public UMVector3 scale;
        public int NrBuildingPoints; // Note: Value is overwritten with buildingPoints.Length on serialize
        public UMVector3[] buildingPoints;
        

        public void Deserialize(DeserializeEvent e)
        {
            ID = e.Reader.ReadUInt32();
            type = (ProceduralEntityType)e.Reader.ReadInt32();

            position = new UMVector3(e.Reader.ReadSingle(), e.Reader.ReadSingle(), e.Reader.ReadSingle());
            rotation = new UMVector3(e.Reader.ReadSingle(), e.Reader.ReadSingle(), e.Reader.ReadSingle());
            scale = new UMVector3(e.Reader.ReadSingle(), e.Reader.ReadSingle(), e.Reader.ReadSingle());

            NrBuildingPoints = e.Reader.ReadInt32();
            buildingPoints = new UMVector3[NrBuildingPoints];
            for(int i = 0; i < NrBuildingPoints; i++)
            {
                buildingPoints[i] = new UMVector3(e.Reader.ReadSingle(), e.Reader.ReadSingle(), e.Reader.ReadSingle());
            }

            
        }

        public void Serialize(SerializeEvent e)
        {
            e.Writer.Write(ID);
            e.Writer.Write((int)type);

            e.Writer.Write(position.x); e.Writer.Write(position.y); e.Writer.Write(position.z);
            e.Writer.Write(rotation.x); e.Writer.Write(rotation.y); e.Writer.Write(rotation.z);
            e.Writer.Write(scale.x); e.Writer.Write(scale.y); e.Writer.Write(scale.z);

            NrBuildingPoints = buildingPoints.Length;
            e.Writer.Write(NrBuildingPoints);

            for (int i = 0; i < NrBuildingPoints; i++) {
                e.Writer.Write(this.buildingPoints[i].x);
                e.Writer.Write(this.buildingPoints[i].y);
                e.Writer.Write(this.buildingPoints[i].z);
            }

        }
    }
}
