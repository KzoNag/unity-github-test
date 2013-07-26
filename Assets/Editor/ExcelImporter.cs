using UnityEngine;
using UnityEditor;
using System.Collections;
using System.IO;
using NPOI.HSSF.UserModel;
using NPOI.HSSF.Util;
using NPOI.SS.UserModel;

public class ExcelImporter : AssetPostprocessor {
	
	static void OnPostprocessAllAssets (
			string[] importedAssets, 
			string[] deletedAssets, 
			string[] movedAssets, 
			string[] movedFromAssetPaths)
	{
		foreach (string file in importedAssets) 
		{
			if (file.EndsWith(".xls"))
			{
				Debug.Log("FilePath:"+file);
				
				using(FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
				{
					IWorkbook book = new HSSFWorkbook(fs);
					
					int sheetNum = book.NumberOfSheets;
					for(int i=0; i<sheetNum; ++i)
					{
						ISheet sheet = book.GetSheetAt(i);
						Debug.Log("Sheet:" + sheet.SheetName);
					}
				}
					
			}
			if (file.EndsWith(".xlsx"))
			{
				
			}
		}
	}
}
