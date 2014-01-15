using System;
using System.Collections;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DinamicTreeview
{
	public class LoadAndSave
	{

		#region Save
		/// <summary>
		/// Save the TreeView content
		/// </summary>
		/// <param name="Tree"></param>
		/// <param name="Filename"></param>
		/// <returns>Errorcode as int</returns>
		public static int SaveTree(TreeView tree, string filename)
		{
			ArrayList al = new ArrayList();
			foreach (TreeNode tn in tree.Nodes)
			{
				al.Add(tn);
			}

			Stream file = File.Open(filename, FileMode.Create);
			BinaryFormatter bf = new BinaryFormatter();
			try
			{
				bf.Serialize(file, al);
			}
			catch (System.Runtime.Serialization.SerializationException e)
			{
				MessageBox.Show("Serialization failed : {0}", e.Message);
				return -1; // ERROR
			}
			file.Close();

			return 0; // OKAY
		}
		#endregion

	
		#region Load
		/// <summary>
		/// Load the TreeView content
		/// </summary>
		/// <param name="Tree"></param>
		/// <param name="Filename"></param>
		/// <returns>Errorcode as int</returns>
		public static int LoadTree(TreeView tree, string filename)
		{
			if (File.Exists(filename))
			{
				Stream file = File.Open(filename, FileMode.Open);
				BinaryFormatter bf = new BinaryFormatter();
				// Object var. init.
				object obj = null;
				try
				{
					obj = bf.Deserialize(file);
				}
				catch (System.Runtime.Serialization.SerializationException e)
				{
					MessageBox.Show("De-Serialization failed : {0}", e.Message);
					return -1;
				}
				file.Close();

				ArrayList nodeList = obj as ArrayList;

				// load Root-Nodes
				foreach (TreeNode node in nodeList)
				{
					tree.Nodes.Add(node);
				}
				return 0;

			}
			else return -2; // File not exist
		}
		
		#endregion
	}
}