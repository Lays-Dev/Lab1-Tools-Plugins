using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.UIElements;

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
}
