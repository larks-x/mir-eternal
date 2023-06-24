﻿using System;

namespace GameServer.Networking
{
	
	[PacketInfoAttribute(Source = PacketSource.Server, Id = 583, Length = 48, Description = "创建行会应答")]
	public sealed class 创建行会应答 : GamePacket
	{
		
		public 创建行会应答()
		{
			
			
		}

		
		[WrappingFieldAttribute(SubScript = 2, Length = 46)]
		public string GuildName;
	}
}
