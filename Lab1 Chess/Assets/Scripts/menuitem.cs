using UnityEngine;
using UnityEditor;
using System.Collections;

public class menuitem
{
    [MenuItem("Menu/Reset Object")]
    public static void ResetObject()
    {

// See if the button click worked

        Debug.Log( "Reset Object button clicked." );

// See if a valid object is selected.

        GameObject selectedObject = Selection.activeGameObject;

        if ( selectedObject == null )
        {
            Debug.Log( "No GameObject selected." );
            return;
        }

        Debug.Log( "Selected: " + selectedObject.name + "." );

//  GameObject must have a Rigidbody, check this here.

        Rigidbody rb = selectedObject.GetComponent<Rigidbody>();
        if ( rb == null )
        {
            Debug.Log( "GameObject has no Rigidbody." );
            return;
        }

        Debug.Log( "Current position: " + rb.position + "." );

// Remove the Rigidbody

        Object.DestroyImmediate(rb);

// Move GameObject to world zero
        selectedObject.transform.position = Vector3.zero;
        //GetComponent<Rigidbody>().position = Vector3.zero;
    }
}
