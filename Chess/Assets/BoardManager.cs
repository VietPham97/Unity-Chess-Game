using UnityEngine;

public class BoardManager : MonoBehaviour 
{
	private const float TILE_SIZE = 1.0f;
	private const float TILE_OFFSET = 0.5f;

	private int selectionX = -1; // nothing is selected
	private int selectionY = -1; // nothing is selected

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
			Debug.Log(hit.point);
		}
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
	}
}
