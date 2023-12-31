namespace UnityEditor.TerrainTools
{
    /// <summary>
    /// An interface that represent the controller for rotating the brush.
    /// </summary>
    public interface IBrushRotationController : IBrushController
    {
        /// <summary>
        /// Gets and sets the brush's rotation.
        /// </summary>
        float brushRotation { get; set; }
        
        /// <summary>
        /// The rotation of the brush without jitter (in degrees).
        /// </summary>
        float brushRotationVal { get; }
        
        /// <summary>
        /// Gets and sets the brush's jitter. 
        /// </summary>
        float brushRotationJitter { get; set; }

        /// <summary>
        /// Gets the current rotation of the brush.
        /// </summary>
        float currentRotation { get; }
    }
}
