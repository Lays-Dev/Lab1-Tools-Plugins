using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.UIElements;

public class pieces : MonoBehaviour
{
    
    public enum PieceType
    {
        Pawn,
        Knight,
        Rook,
        Bishop,
        Queen,
        King
    }

    public PieceType pieceType;

    //private SpriteRenderer spriteRenderer;
    /*
    public Texture pawnSprite;
    public Texture knightSprite;
    public Texture rookSprite;
    public Texture bishopSprite;
    public Texture queenSprite;
    public Texture kingSprite;
    */



    // Start is called before the first frame update
    void Start()
    {
        //spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        

        
    }

    void OnDrawGizmos()
    {
        switch(pieceType)
        {
            case(PieceType.Pawn):
            Gizmos.DrawIcon(transform.position,"Chess_plt60", true, Color.red);
            break;

            case(PieceType.Knight):
            Gizmos.DrawIcon(transform.position,"Chess_nlt60", true, Color.red);
            break;
        }
        
    }
}
