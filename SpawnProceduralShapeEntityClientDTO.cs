using Assets.DTOs;
using DarkRift;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace UnityMultiplayerDRPlugin.DTOs
{
    class SpawnProceduralShapeEntityClientDTO : IDarkRiftSerializable
    {
        public ProceduralEntityType type;
        public int NrBuildingPoints; // Note: Value is overwritten with buildingPoints.Length on serialize
        public Vector3[] buildingPoints;

        public void Deserialize(DeserializeEvent e)
        {
            type = (ProceduralEntityType)e.Reader.ReadInt32();
            NrBuildingPoints = e.Reader.ReadInt32();
            buildingPoints = new Vector3[NrBuildingPoints];
            for(int i = 0; i < NrBuildingPoints; i++)
            {
                buildingPoints[i] = new Vector3(e.Reader.ReadSingle(), e.Reader.ReadSingle(), e.Reader.ReadSingle());
            }
        }

        public void Serialize(SerializeEvent e)
        {
            e.Writer.Write((int)type);

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
