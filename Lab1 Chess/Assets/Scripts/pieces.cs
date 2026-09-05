using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.UIElements;
using UnityEditor;

public class pieces : MonoBehaviour
{
    // Enum of piece types
    public enum PieceType
    {
        Pawn,
        Knight,
        Rook,
        Bishop,
        Queen,
        King
    }

    public PieceType pieceType;                 // Public enum variable for selecting piece type

    public Color tint = Color.white;            // Public color picker for changing the piece color in the editor

    public Color outlineColor = Color.yellow;   // Customize the outline color in the inspector

    public Color pathColor = Color.white;       // Public color picker for the piece path markers

    // Array of texture names for different chess pieces.
    public string[] pieceIcons =
    {
        "Chess_plt60",
        "Chess_nlt60",
        "Chess_rlt60",
        "Chess_blt60",
        "Chess_qlt60",
        "Chess_klt60",
    };



    // This method fills in data from the piece type enum and the icon array to draw the selected texture
    void OnDrawGizmos()
    {
        Gizmos.DrawIcon(transform.position, pieceIcons[(int)pieceType], true, tint);
    }

// Used to run handles in the editor window
#if UNITY_EDITOR

    private void OnDrawGizmosSelected()
    {

        Handles.color = outlineColor;
        // Specific float values because the "board" covers the outline
        Handles.DrawWireCube(transform.position, new Vector3(.9f, .9f, 0f));

        // Show the different valid moves when the piece is selected
        ShowMoves();
    }

#endif


    
    
    void ShowMoves()
    {
        Gizmos.color = pathColor;   // Change the color of the piece paths

        // Change visible moves based on the piece type
        switch(pieceType)
        {

            case(PieceType.Pawn):
                // Because pawns only have one possible move, they don't need a dedicated separate function
                Gizmos.DrawLine(transform.position, new Vector3(transform.position.x, transform.position.y + 2f, 0f));
            break;

            case(PieceType.Knight):
                DrawKnightPaths();
            break;

            case (PieceType.Rook):
                DrawRookPaths();
            break;

            case (PieceType.Bishop):
                DrawBishopPaths();
            break;
            
            case (PieceType.Queen):
                DrawQueenPaths();
            break;

            case (PieceType.King):
                DrawKingPaths();
            break;
        }
        
    }

    void DrawKnightPaths()
    {
        Vector3[] kightPaths =
        {
            new Vector3(transform.position.x, transform.position.y, 0f),
            new Vector3(transform.position.x + 1f, transform.position.y + 2f, 0f),
            new Vector3(transform.position.x, transform.position.y, 0f),
            new Vector3(transform.position.x + 2f, transform.position.y + 1f, 0f),
            new Vector3(transform.position.x, transform.position.y, 0f),
            new Vector3(transform.position.x + 1f, transform.position.y - 2f, 0f),
            new Vector3(transform.position.x, transform.position.y, 0f),
            new Vector3(transform.position.x + 2f, transform.position.y - 1f, 0f),
            new Vector3(transform.position.x, transform.position.y, 0f),
            new Vector3(transform.position.x - 1f, transform.position.y + 2f, 0f),
            new Vector3(transform.position.x, transform.position.y, 0f),
            new Vector3(transform.position.x - 2f, transform.position.y + 1f, 0f),
            new Vector3(transform.position.x, transform.position.y, 0f),
            new Vector3(transform.position.x - 1f, transform.position.y - 2f, 0f),
            new Vector3(transform.position.x, transform.position.y, 0f),
            new Vector3(transform.position.x - 2f, transform.position.y - 1f, 0f)
        };

        Gizmos.DrawLineList(kightPaths);
    }

    void DrawRookPaths()
    {
        Vector3[] rookPaths =
        {
            new Vector3(transform.position.x, transform.position.y, 0f),
            new Vector3(transform.position.x, transform.position.y + 7f, 0f),
            new Vector3(transform.position.x, transform.position.y, 0f),
            new Vector3(transform.position.x + 7f, transform.position.y, 0f),
            new Vector3(transform.position.x, transform.position.y, 0f),
            new Vector3(transform.position.x, transform.position.y - 7f, 0f),
            new Vector3(transform.position.x, transform.position.y, 0f),
            new Vector3(transform.position.x - 7f, transform.position.y, 0f)
        };

        Gizmos.DrawLineList(rookPaths);
    }

    void DrawBishopPaths()
    {
        Vector3[] bishopPaths =
        {
            new Vector3(transform.position.x, transform.position.y, 0f),
            new Vector3(transform.position.x + 7f, transform.position.y + 7f, 0f),
            new Vector3(transform.position.x, transform.position.y, 0f),
            new Vector3(transform.position.x + 7f, transform.position.y - 7f, 0f),
            new Vector3(transform.position.x, transform.position.y, 0f),
            new Vector3(transform.position.x - 7f, transform.position.y + 7f, 0f),
            new Vector3(transform.position.x, transform.position.y, 0f),
            new Vector3(transform.position.x - 7f, transform.position.y - 7f, 0f)
        };

        Gizmos.DrawLineList(bishopPaths);
    }

    void DrawQueenPaths()
    {
        Vector3[] queenPaths =
        {
            new Vector3(transform.position.x, transform.position.y, 0f),
            new Vector3(transform.position.x, transform.position.y + 7f, 0f),
            new Vector3(transform.position.x, transform.position.y, 0f),
            new Vector3(transform.position.x + 7f, transform.position.y, 0f),
            new Vector3(transform.position.x, transform.position.y, 0f),
            new Vector3(transform.position.x, transform.position.y - 7f, 0f),
            new Vector3(transform.position.x, transform.position.y, 0f),
            new Vector3(transform.position.x - 7f, transform.position.y, 0f),
            new Vector3(transform.position.x, transform.position.y, 0f),
            new Vector3(transform.position.x + 7f, transform.position.y + 7f, 0f),
            new Vector3(transform.position.x, transform.position.y, 0f),
            new Vector3(transform.position.x + 7f, transform.position.y - 7f, 0f),
            new Vector3(transform.position.x, transform.position.y, 0f),
            new Vector3(transform.position.x - 7f, transform.position.y + 7f, 0f),
            new Vector3(transform.position.x, transform.position.y, 0f),
            new Vector3(transform.position.x - 7f, transform.position.y - 7f, 0f)
        };

        Gizmos.DrawLineList(queenPaths);
    }

    void DrawKingPaths()
    {
        Vector3[] kingPaths =
        {
            new Vector3(transform.position.x, transform.position.y, 0f),
            new Vector3(transform.position.x, transform.position.y + 1f, 0f),
            new Vector3(transform.position.x, transform.position.y, 0f),
            new Vector3(transform.position.x + 1f, transform.position.y, 0f),
            new Vector3(transform.position.x, transform.position.y, 0f),
            new Vector3(transform.position.x, transform.position.y - 1f, 0f),
            new Vector3(transform.position.x, transform.position.y, 0f),
            new Vector3(transform.position.x - 1f, transform.position.y, 0f),
            new Vector3(transform.position.x, transform.position.y, 0f),
            new Vector3(transform.position.x + 1f, transform.position.y + 1f, 0f),
            new Vector3(transform.position.x, transform.position.y, 0f),
            new Vector3(transform.position.x + 1f, transform.position.y - 1f, 0f),
            new Vector3(transform.position.x, transform.position.y, 0f),
            new Vector3(transform.position.x - 1f, transform.position.y + 1f, 0f),
            new Vector3(transform.position.x, transform.position.y, 0f),
            new Vector3(transform.position.x - 1f, transform.position.y - 1f, 0f)
        };

        Gizmos.DrawLineList(kingPaths);
    }
    
}
