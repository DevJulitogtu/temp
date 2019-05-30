using System.Windows.Forms;

namespace PolicyConnect
{
    internal class ToolStripHelper
    {
        private ToolStripHelper()
        {
        }

        internal static void MoveToFirst(ToolStripButton bnvNavMoveFirstItem, ToolStripButton bnvNavMovePreviousItem, ToolStripButton bnvNavMoveNextItem, ToolStripButton bnvNavMoveLastItem)
        {
            bnvNavMoveFirstItem.Enabled = false;
            bnvNavMovePreviousItem.Enabled = false;
            bnvNavMoveNextItem.Enabled = true;
            bnvNavMoveLastItem.Enabled = true;
        }

        internal static void MoveToPrevious(ToolStripButton bnvNavMoveFirstItem, ToolStripButton bnvNavMovePreviousItem, ToolStripButton bnvNavMoveNextItem, ToolStripButton bnvNavMoveLastItem, int currentRecordNumber)
        {
            bnvNavMoveNextItem.Enabled = true;
            bnvNavMoveLastItem.Enabled = true;

            if (currentRecordNumber == 1)
            {
                bnvNavMoveFirstItem.Enabled = false;
                bnvNavMovePreviousItem.Enabled = false;
            }
        }

        internal static void MoveToNext(ToolStripButton bnvNavMoveFirstItem, ToolStripButton bnvNavMovePreviousItem, ToolStripButton bnvNavMoveNextItem, ToolStripButton bnvNavMoveLastItem, int currentPageNumber, int totalNumberOfPages)
        {
            bnvNavMoveFirstItem.Enabled = true;
            bnvNavMovePreviousItem.Enabled = true;

            if (currentPageNumber == totalNumberOfPages)
            {
                bnvNavMoveNextItem.Enabled = false;
                bnvNavMoveLastItem.Enabled = false;
            }
        }

        internal static void MoveToLast(ToolStripButton bnvNavMoveFirstItem, ToolStripButton bnvNavMovePreviousItem, ToolStripButton bnvNavMoveNextItem, ToolStripButton bnvNavMoveLastItem)
        {
            bnvNavMoveFirstItem.Enabled = true;
            bnvNavMovePreviousItem.Enabled = true;
            bnvNavMoveNextItem.Enabled = false;
            bnvNavMoveLastItem.Enabled = false;
        }
    }
}
