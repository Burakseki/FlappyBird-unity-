using UnityEngine;

public class Parallax : MonoBehaviour
{
 private MeshRenderer meshRenderer;
 public float backSpeed;

 private void Awake() 
 {
     meshRenderer = GetComponent<MeshRenderer>();
 }

 private void Update() 
 {
    meshRenderer.material.mainTextureOffset += Vector2.right * backSpeed * Time.deltaTime;    
 }



}
