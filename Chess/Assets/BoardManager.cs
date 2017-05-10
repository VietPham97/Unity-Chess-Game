using UnityEngine;
using System.Collections.Generic;

public class BoardManager : MonoBehaviour 
{
	private const float TILE_SIZE = 1.0f;
	private const float TILE_OFFSET = 0.5f;

	private int selectionX = -1; // nothing is selected
	private int selectionY = -1; // nothing is selected

	public List<GameObject> chessmanPrefabs;
	private List<GameObject> activeChessman = new List<GameObject>();

	private void Start()
	{
		SpawnChessman(0, Vector3.zero); // White King
	}

	private void Update()
	{
		UpdateSelection();
		DrawChessboard();
	}

	private void UpdateSelection()
	{
		if (!Camera.main) return;

		RaycastHit hit;
		if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 25.0f, LayerMask.GetMask("ChessBoard")))
		{
			selectionX = (int)hit.point.x;
			selectionY = (int)hit.point.z;
		}
		else
		{
			selectionX = -1;
			selectionY = -1;
		}
	}

	private void SpawnChessman(int index, Vector3 position)
	{
		GameObject go = Instantiate (chessmanPrefabs[index], position, Quaternion.identity) as GameObject;
		go.transform.SetParent (transform);
		activeChessman.Add(go);
	}

	private void DrawChessboard()
	{
		Vector3 widthLine = Vector3.right * 8;
		Vector3 heigthLine = Vector3.forward * 8;

		for (int i = 0; i <= 8; i++)
		{
			Vector3 startPos = Vector3.forward * i;
			Debug.DrawLine(startPos, startPos + widthLine);
			for (int j = 0; j <= 8; j++)
			{
				startPos = Vector3.right * j;
				Debug.DrawLine(startPos, startPos + heigthLine);	
			}	
		}

		// Draw the hit cross
		if (selectionX >= 0 && selectionY >= 0)
		{
			Debug.DrawLine(
				Vector3.forward * selectionY + Vector3.right * selectionX, 
				Vector3.forward * (selectionY + 1) + Vector3.right * (selectionX + 1)
			);

			Debug.DrawLine(
				Vector3.forward * (selectionY + 1) + Vector3.right * selectionX, 
				Vector3.forward * selectionY + Vector3.right * (selectionX + 1)
			);
		}
	}
}
