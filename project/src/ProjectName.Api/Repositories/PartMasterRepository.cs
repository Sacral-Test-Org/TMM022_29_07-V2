using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using ProjectName.Api.Models;
using ProjectName.Api.DTOs;

namespace ProjectName.Api.Repositories
{
    public class PartMasterRepository
    {
        private readonly string _connectionString;

        public PartMasterRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public PartMasterDTO GetPartMasterData()
        {
            PartMasterDTO partMasterDTO = new PartMasterDTO();

            using (OracleConnection connection = new OracleConnection(_connectionString))
            {
                connection.Open();
                using (OracleCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT GROUP_ID, PARTNO, PART_STATUS, PART_DESC, LINE_ID, UNIT_ID FROM PART_MASTER WHERE ROWNUM = 1";
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            partMasterDTO.GroupId = reader["GROUP_ID"].ToString();
                            partMasterDTO.PartNo = reader["PARTNO"].ToString();
                            partMasterDTO.PartStatus = reader["PART_STATUS"].ToString();
                            partMasterDTO.PartDesc = reader["PART_DESC"].ToString();
                            partMasterDTO.LineId = reader["LINE_ID"].ToString();
                            partMasterDTO.UnitId = reader["UNIT_ID"].ToString();
                        }
                    }
                }
            }

            partMasterDTO.CurrentFormName = "PART_MASTER";
            partMasterDTO.CurrentDate = GetCurrentDate();
            partMasterDTO.Mode = "Create Mode";

            return partMasterDTO;
        }

        public string GetCurrentDate()
        {
            return DateTime.Now.ToString("yyyy-MM-dd");
        }
    }
}
