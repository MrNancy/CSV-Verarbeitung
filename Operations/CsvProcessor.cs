﻿using System;
using System.IO;
using System.Windows.Forms;
using File = System.IO.File;
using KBCsv;
using System.Text;
using System.Text.RegularExpressions;
using Syncfusion.Windows.Forms;
using System.Runtime.CompilerServices;

namespace CSV_Verarbeitung.Operations
{
    class CsvProcessor
    {
        public static string filePath = null;
        public static bool isDone = false;
        public static char seperator = ';';
        public static bool firstRowContainsFieldNames = false;
        public static int columns = 0;
        public static string dataContent = "";
        public static string csvData;

        public static void SaveCsv(DataGridView dataGridView)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                Title = "CSV Datei Speichern",
                DefaultExt = "csv",
                Filter = "CSV Dateien (*.csv)|*.csv"
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string outputFile = saveFileDialog.FileName;
                bool contineSaving = true;

                if (File.Exists(outputFile))
                {
                    Interface.DesignMessageBox(MessageBoxButtons.YesNo);
                    DialogResult dialogResult = MessageBoxAdv.Show("Möchten Sie die Datei wirklich überschreiben?", "Datei überschreiben", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    ;
                    if (dialogResult == DialogResult.Yes)
                    {
                        contineSaving = true;
                        File.Delete(outputFile);
                    }
                }
                else
                {
                    contineSaving = true;
                }
                if (contineSaving == true)
                {
                    try
                    {
                        StringBuilder UptoMain = new StringBuilder();
                        StreamWriter file = new StreamWriter(outputFile, true, Encoding.UTF8, 512);


                        string header = "";
                        foreach (DataGridViewColumn column in dataGridView.Columns)
                        {
                            header += column.HeaderText + ";";
                        }
                        header = header.Remove(header.Length - 1);
                        UptoMain.AppendLine(header);


                        foreach (DataGridViewRow row in dataGridView.Rows)
                        {
                            string line = "";
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                if (cell.Value != null)
                                {
                                    string val = cell.Value.ToString();

                                    bool check = false;
                                    if (int.TryParse(val.Trim(), out int isInt))
                                    {
                                        check = true;
                                    }
                                    if (double.TryParse(val.Trim(), out double isDouble))
                                    {
                                        check = true;
                                    }

                                    if (check == false && val != null)
                                    {
                                        val = '"' + val + '"';
                                    }


                                    line += val + ";";
                                }
                                else
                                {
                                    line += ";";
                                }
                            }
                            line = line.Remove(line.Length - 1);
                            UptoMain.AppendLine(line);
                        }
                        file.WriteLine(UptoMain);
                        file.Close();
                        file.Dispose();
                    }
                    catch (ArgumentException e)
                    {
                        Interface.DesignMessageBox(MessageBoxButtons.OK);
                        MessageBoxAdv.Show("Das Speichern der Datei ist fehlgeschlagen!" + Environment.NewLine + "---" + Environment.NewLine + e.ToString(), "Speichern fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        public static void OpenFile(Label pathLabel, PictureBox loadPb, PictureBox loadLoadingPb, DataGridView dataGridView)
        {
            loadPb.Visible = true;
            loadLoadingPb.Visible = true;
            CsvProcessor.OpenFileDialog();
            CsvProcessor.PopulateDataGridView(dataGridView);
            pathLabel.Text = CsvProcessor.filePath;
        }

        private static void OpenFileDialog()
        {
            OpenFileDialog fileDialog = new OpenFileDialog
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                Filter = "CSV Dateien (*.csv)|*.csv",
                FilterIndex = 0,
                RestoreDirectory = true
            };
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(fileDialog.FileName))
                {
                    filePath = fileDialog.FileName;
                }
            }
        }

        public static string PopulateCsvString(DataGridView dataGridView)
        {
            string csvDataString = null;
            if (dataGridView.Columns.Count > 1 && dataGridView.Rows.Count > 1)
            {
                foreach (DataGridViewColumn dataGridViewColumn in dataGridView.Columns)
                {
                    csvDataString += dataGridViewColumn.HeaderText.Replace(Environment.NewLine, string.Empty) + ";";
                }
                csvDataString = csvDataString.Remove(csvDataString.Length - 1) + Environment.NewLine;

                foreach (DataGridViewRow dataGridViewRow in dataGridView.Rows)
                {
                    foreach (DataGridViewCell dataGridViewCell in dataGridViewRow.Cells)
                    {
                        object tempVal = dataGridViewCell.Value;
                        if(tempVal is null)
                        {
                            csvData += ";";
                        }
                        else
                        {
                            string value = Regex.Replace(tempVal.ToString(), @"\n|\r", "");
                            csvDataString += value + ";";
                        }
                    }
                    csvDataString = csvDataString.Remove(csvDataString.Length - 1) + Environment.NewLine;
                }
                return csvDataString;
            }
            else
            {
                Interface.DesignMessageBox(MessageBoxButtons.OK);
                MessageBoxAdv.Show("Sie müssen mindestens zwei Spalten wählen!", "Fehler beim Laden des Charts", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }

        public static void PopulateRow(DataGridView dataGridView, string row)
        {
            string tempFetch = row;
            tempFetch = tempFetch.Remove(tempFetch.Length - 1);
            string[] tempRow = tempFetch.Split(';');
            dataGridView.Rows.Add(tempRow);
        }
        public static void PopulateDataGridView(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();
            dataGridView.Refresh();

            if (File.Exists(filePath))
            {
                FileInfo fi = new FileInfo(filePath);

                if (fi.Length > 0)
                {
                    try
                    {
                        using (FileStream fs = File.Open(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                        using (BufferedStream bs = new BufferedStream(fs))
                        using (var streamReader = new StreamReader(fs))
                        using (var csvReader = new CsvReader(streamReader))
                        {
                            foreach (string entry in streamReader.ReadLine().Split(seperator))
                            {
                                dataGridView.Columns.Add(columns.ToString(), entry);
                            }
                            while (csvReader.HasMoreRecords)
                            {
                                string tempFetch = csvReader.ReadDataRecord().ToString();
                                tempFetch = tempFetch.Remove(tempFetch.Length - 1);
                                string[] row = tempFetch.Split(';');
                                dataGridView.Rows.Add(row);
                            }
                        }
                        isDone = true;
                    }
                    catch
                    {
                        filePath = null;
                        Interface.DesignMessageBox(MessageBoxButtons.OK);
                        MessageBoxAdv.Show("Beim Laden der Datei ist ein Fehler aufgetreten!", "Datei konnte nicht geladen werden", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    isDone = true;
                }
            }
        }
    }
}
