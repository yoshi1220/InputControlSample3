namespace InputControlSample.Utilities
{
    public static class VBStrings
    {
        /// <summary>
        /// 文字列をShift-JISに変換することにより
        /// 半角1バイト、全角2バイトの判定を行う
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int LenB(string target)
        {
            return System.Text.Encoding.GetEncoding("Shift_JIS").GetByteCount(target);
        }
    }
}
