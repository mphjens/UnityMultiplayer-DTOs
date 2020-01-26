using Assets.DTOs;
using DarkRift;
using System;

namespace UnityMultiplayerDRPlugin.DTOs
{
	internal class SpawnProceduralShapeEntityServerDTO : IDarkRiftSerializable
	{
		public uint ID;

		public ProceduralEntityType type;

		public UMVector3 position;

		public UMVector3 rotation;

		public UMVector3 scale;

		public int NrBuildingPoints;

		public UMVector3[] buildingPoints;

		public SpawnProceduralShapeEntityServerDTO()
		{
		}

		public void Deserialize(DeserializeEvent e)
		{
			this.ID = e.Reader.ReadUInt32();
			this.type = (ProceduralEntityType)e.Reader.ReadInt32();
			this.position = new UMVector3(e.Reader.ReadSingle(), e.Reader.ReadSingle(), e.Reader.ReadSingle());
			this.rotation = new UMVector3(e.Reader.ReadSingle(), e.Reader.ReadSingle(), e.Reader.ReadSingle());
			this.scale = new UMVector3(e.Reader.ReadSingle(), e.Reader.ReadSingle(), e.Reader.ReadSingle());
			this.NrBuildingPoints = e.Reader.ReadInt32();
			this.buildingPoints = new UMVector3[this.NrBuildingPoints];
			for (int i = 0; i < this.NrBuildingPoints; i++)
			{
				this.buildingPoints[i] = new UMVector3(e.Reader.ReadSingle(), e.Reader.ReadSingle(), e.Reader.ReadSingle());
			}
		}

		public void Serialize(SerializeEvent e)
		{
			e.Writer.Write(this.ID);
			e.Writer.Write((int)this.type);
			e.Writer.Write(this.position.x);
			e.Writer.Write(this.position.y);
			e.Writer.Write(this.position.z);
			e.Writer.Write(this.rotation.x);
			e.Writer.Write(this.rotation.y);
			e.Writer.Write(this.rotation.z);
			e.Writer.Write(this.scale.x);
			e.Writer.Write(this.scale.y);
			e.Writer.Write(this.scale.z);
			this.NrBuildingPoints = (int)this.buildingPoints.Length;
			e.Writer.Write(this.NrBuildingPoints);
			for (int i = 0; i < this.NrBuildingPoints; i++)
			{
				e.Writer.Write(this.buildingPoints[i].x);
				e.Writer.Write(this.buildingPoints[i].y);
				e.Writer.Write(this.buildingPoints[i].z);
			}
		}
	}
}