using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConvertToRegularMesh : MonoBehaviour
{
    [ContextMenu("Convert to regular mesh")]
    private void Convert()
    {
        SkinnedMeshRenderer skinnedMeshRenderer = GetComponent<SkinnedMeshRenderer>();
        MeshRenderer meshRenderer = gameObject.AddComponent<MeshRenderer>();
        MeshFilter meshFilter = gameObject.AddComponent<MeshFilter>();

        meshRenderer.sharedMaterials = skinnedMeshRenderer.sharedMaterials;
        meshFilter.sharedMesh = skinnedMeshRenderer.sharedMesh;

        DestroyImmediate(skinnedMeshRenderer);
        DestroyImmediate(this);
    }
}
