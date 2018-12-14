using System;

namespace FBLib1
{
	[Flags]
	internal enum ESFGAO
	{
		SFGAO_CANCOPY = 1,
		SFGAO_CANMOVE = 2,
		SFGAO_CANLINK = 4,
		SFGAO_CANRENAME = 0x10,
		SFGAO_CANDELETE = 0x20,
		SFGAO_HASPROPSHEET = 0x40,
		SFGAO_DROPTARGET = 0x100,
		SFGAO_CAPABILITYMASK = 0x177,
		SFGAO_LINK = 0x10000,
		SFGAO_SHARE = 0x20000,
		SFGAO_READONLY = 0x40000,
		SFGAO_GHOSTED = 0x80000,
		SFGAO_DISPLAYATTRMASK = 0xF0000,
		SFGAO_FILESYSANCESTOR = 0x10000000,
		SFGAO_FOLDER = 0x20000000,
		SFGAO_FILESYSTEM = 0x40000000,
		SFGAO_HASSUBFOLDER = -2147483648,
		SFGAO_CONTENTSMASK = -2147483648,
		SFGAO_VALIDATE = 0x1000000,
		SFGAO_REMOVABLE = 0x2000000,
		SFGAO_COMPRESSED = 0x4000000
	}
}
