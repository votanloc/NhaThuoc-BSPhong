using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhongKham.Forms
{
    internal class TonKhoService
    {
        /// <summary>
        /// Tính lại số nhập, số xuất, tồn kho theo ma_thuoc + lsx + hsd
        /// rồi insert/update vào tbl_ton_kho.
        /// </summary>
        public static void RecalculateTonKho(string maThuoc, string lsx, DateTime? hsd)
        {
            if (string.IsNullOrWhiteSpace(maThuoc)) return;

            string sql = @"
            INSERT INTO tbl_ton_kho
            (
                ma_thuoc, lsx, hsd,
                so_nhap, so_xuat, ton_kho,
                ngay_nhap_cuoi, ngay_xuat_cuoi, updated_at
            )
            SELECT
                @ma_thuoc AS ma_thuoc,
                @lsx      AS lsx,
                @hsd      AS hsd,

                COALESCE((
                    SELECT SUM(nk.so_luong)
                    FROM tbl_nk_ct nk
                    WHERE nk.ma_thuoc = @ma_thuoc
                      AND COALESCE(nk.lsx,'') = COALESCE(@lsx,'')
                      AND nk.hsd = @hsd
                      AND nk.delete_at IS NULL
                ),0) AS so_nhap,

                COALESCE((
                    SELECT SUM(tu.so_luong)
                    FROM tbl_tu_ct tu
                    WHERE tu.ma_thuoc = @ma_thuoc
                      AND COALESCE(tu.lsx,'') = COALESCE(@lsx,'')
                      AND tu.hsd = @hsd
                      AND tu.delete_at IS NULL
                      AND tu.khong_lay = 0
                ),0) AS so_xuat,

                (
                    COALESCE((
                        SELECT SUM(nk.so_luong)
                        FROM tbl_nk_ct nk
                        WHERE nk.ma_thuoc = @ma_thuoc
                          AND COALESCE(nk.lsx,'') = COALESCE(@lsx,'')
                          AND nk.hsd = @hsd
                          AND nk.delete_at IS NULL
                    ),0)
                    -
                    COALESCE((
                        SELECT SUM(tu.so_luong)
                        FROM tbl_tu_ct tu
                        WHERE tu.ma_thuoc = @ma_thuoc
                          AND COALESCE(tu.lsx,'') = COALESCE(@lsx,'')
                          AND tu.hsd = @hsd
                          AND tu.delete_at IS NULL
                          AND tu.khong_lay = 0
                    ),0)
                ) AS ton_kho,

                (
                    SELECT MAX(nk.date_in)
                    FROM tbl_nk_ct nk
                    WHERE nk.ma_thuoc = @ma_thuoc
                      AND COALESCE(nk.lsx,'') = COALESCE(@lsx,'')
                      AND nk.hsd = @hsd
                      AND nk.delete_at IS NULL
                ) AS ngay_nhap_cuoi,

                (
                    SELECT MAX(tu.date_in)
                    FROM tbl_tu_ct tu
                    WHERE tu.ma_thuoc = @ma_thuoc
                      AND COALESCE(tu.lsx,'') = COALESCE(@lsx,'')
                      AND tu.hsd = @hsd
                      AND tu.delete_at IS NULL
                      AND tu.khong_lay = 0
                ) AS ngay_xuat_cuoi,

                NOW() AS updated_at

            ON DUPLICATE KEY UPDATE
                so_nhap = VALUES(so_nhap),
                so_xuat = VALUES(so_xuat),
                ton_kho = VALUES(ton_kho),
                ngay_nhap_cuoi = VALUES(ngay_nhap_cuoi),
                ngay_xuat_cuoi = VALUES(ngay_xuat_cuoi),
                updated_at = NOW();";

            Helpers.MySqlHelper.ExecuteNonQuery(
                sql,
                new MySqlParameter("@ma_thuoc", maThuoc),
                new MySqlParameter("@lsx", (object?)lsx ?? DBNull.Value),
                new MySqlParameter("@hsd", (object?)hsd ?? DBNull.Value)
            );
        }
    }
}
