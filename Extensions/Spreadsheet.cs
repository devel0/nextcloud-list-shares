namespace SearchAThing.NextCloudUtils;

public static partial class Extensions
{

    public static (IXLRange rng_used, int col_cnt, int row_cnt) FinalizeWorksheet(this IXLWorksheet ws)
    {
        var rng_used = ws.RangeUsed();
        var col_cnt = rng_used.ColumnCount();
        var row_cnt = rng_used.RowCount();

        (IXLRange rng_used, int row_cnt, int col_cnt) res = (rng_used, row_cnt, col_cnt);

        ws.Range(1, 1, row_cnt, col_cnt).SetAutoFilter();
        for (int c = 1; c <= col_cnt; c++) ws.Column(c).AdjustToContents();

        ws.SheetView.Freeze(rows: 1, columns: 0);

        return res;
    }

}