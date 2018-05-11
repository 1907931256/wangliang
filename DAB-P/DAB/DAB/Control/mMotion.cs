
namespace DAB
{
	
	public sealed class Tools
	{
		
#region 普通变量
		public static double Pi;
		public static int SomeOneOnWorkTime;
		/// <summary>
		/// My.Application.Info.DirectoryPath + "\Setting.dll"
		/// </summary>
		/// <remarks></remarks>
		public static string IniFileName = (new Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase()).Info.DirectoryPath + "\\Setting.dll";
#endregion
		
#region 马达变量
		/// <summary>
		/// 第一张板卡的轴数
		/// </summary>
		/// <remarks></remarks>
		public const short Card1OfAxis = 8;
		/// <summary>
		/// 第二张板卡轴数
		/// </summary>
		/// <remarks></remarks>
		public const short Card2OfAxis = 4;

        /// <summary>
        /// 记录轴目标的位置（脉冲）AxisTmplPos(卡号[0-1] ,轴号[1-8] )
        /// </summary>
        /// <remarks></remarks>
        public static int[,] AxisTmplPos = new int[5, 9];
		
		
		/// <summary>
		/// 丝杆导成
		/// </summary>
		/// <remarks></remarks>
		public static double[,] LeadLength = new double[,] {
            {0, 88.56, 88.56, 88.56, 2, 2, 2, 2, 2}, 
			{1, 10, 10, 10, 10, 10, 10, 10, 10}, 
			{2, 10, 10, 10, 360, 10, 10, 10, 10}, 
			{3, 10, 10, 10, 360, 10, 10, 10, 10}, 
			{4, 10, 10, 10, 360, 10, 10, 10, 10}};
		
		/// <summary>
		/// 减速比
		/// </summary>
		/// <remarks></remarks>
		public static double[,] GeerRate = new double[,] {
            {0, 1, 1, 1, 1, 1, 1, 1, 1}, 
			{1, 1, 1, 1, 1, 1, 1, 1, 1}, 
			{2, 1, 1, 1, 1, 1, 1, 1, 1}, 
			{3, 1, 1, 1, 1, 1, 1, 1, 1}, 
			{4, 1, 1, 1, 1, 1, 1, 1, 1}};
		
		/// <summary>
		/// 每圈的脉冲数
		/// </summary>
		/// <remarks></remarks>
        public static double[,] PlusPerR = new double[,] {
            {0, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000}, 
			{1, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000}, 
			{2, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000}, 
			{3, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000}, 
			{4, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000}};
		
		/// <summary>
		/// 轴的速度mm/s
		/// </summary>
		/// <remarks></remarks>
		public static double[,] AxisSpeed = new double[,] {{0, 0, 0, 0, 0, 0, 0, 0, 0}, 
			{1, 0, 0, 0, 0, 0, 0, 0, 0}, 
			{2, 0, 0, 0, 0, 0, 0, 0, 0}, 
			{3, 0, 0, 0, 0, 0, 0, 0, 0}, 
			{4, 0, 0, 0, 0, 0, 0, 0, 0}};
		
		public static double[,] AxisAcc = new double[,] {{0, 2, 2, 2, 2, 2, 2, 2, 2}, 
			{1, 2, 2, 2, 2, 2, 2, 2, 2}, 
			{2, 2, 2, 2, 2, 2, 2, 2, 2}, 
			{3, 2, 2, 2, 2, 2, 2, 2, 2}, 
			{4, 2, 2, 2, 2, 2, 2, 2, 2}};
		
		public static double[,] AxisDec = new double[,] {{0, 2, 2, 2, 2, 2, 2, 2, 2}, 
			{1, 2, 2, 2, 2, 2, 2, 2, 2}, 
			{2, 2, 2, 2, 2, 2, 2, 2, 2}, 
			{3, 2, 2, 2, 2, 2, 2, 2, 2}, 
			{4, 2, 2, 2, 2, 2, 2, 2, 2}};
				
#endregion
			
	}	
}
