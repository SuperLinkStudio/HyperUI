namespace HyperUIWidget
{
    /// <summary>
    /// CilpPath动画方向预设
    /// </summary>
    public class CilpPathAnimationDirectionDefault
    {
        /// <summary>
        /// 方向枚举
        /// </summary>
        public enum DirectionDefault
        {
            FromTop,
            ToTop,
            FromLeft,
            ToLeft,
            FromRight,
            ToRight,
            FromBottom,
            ToBottom
        }

        /// <summary>
        /// 从方向获取对应的class
        /// </summary>
        /// <param name="direction">方向</param>
        /// <returns>对应的class</returns>
        public static string GetAnimationDefaultClassFromDirection(DirectionDefault direction)
        {
            switch (direction)
            {
                case DirectionDefault.FromTop:
                    return "clip-path-animation--from-top";
                case DirectionDefault.ToTop:
                    return "clip-path-animation--to-top";
                case DirectionDefault.FromLeft:
                    return "clip-path-animation--from-left";
                case DirectionDefault.ToLeft:
                    return "clip-path-animation--to-left";
                case DirectionDefault.FromRight:
                    return "clip-path-animation--from-right";
                case DirectionDefault.ToRight:
                    return "clip-path-animation--to-right";
                case DirectionDefault.FromBottom:
                    return "clip-path-animation--from-bottom";
                case DirectionDefault.ToBottom:
                    return "clip-path-animation--to-bottom";
                default:
                    return "";
            }
        }
    }
}
