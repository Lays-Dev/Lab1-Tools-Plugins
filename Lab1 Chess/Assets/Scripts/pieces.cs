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

    public PieceType pieceType;         // Public enum variable for selecting piece type

    public Color tint = Color.white;    // Public color picker for changing the piece color in the editor

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


// Customize the outline color in the inspector

    public Color outlineColor = Color.yellow;

// Used to run handles in the editor window
#if UNITY_EDITOR

    private void OnDrawGizmosSelected()
    {

        Handles.color = outlineColor;
        // Specific float values because the "board" covers the outline
        Handles.DrawWireCube(transform.position, new Vector3(.9f, .9f, 0f));

    }

#endif


    
    /*
    void OnDrawGizmos()
    {
        // Change piece type based on the enum
        switch(pieceType)
        {

            case(PieceType.Pawn):
            Gizmos.DrawIcon(transform.position,"Chess_plt60", true, tint);
            break;

            case(PieceType.Knight):
            Gizmos.DrawIcon(transform.position,"Chess_nlt60", true, tint);
            break;
            
        }
        
    }
    */
}
