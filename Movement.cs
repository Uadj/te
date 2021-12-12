[SerializeField]
private float moveSpeed =0f;
[SerializeField]
private Vector moveDirection = Vector3.zero;

private void Update()
{
    transform.position += moveDirection * moveSpeed*Time.deltaTime;
}
public void MoveTo(Vector3 direction)
{
    moveDirecion = direction;
}
