import pandas as pd

# Load the data from the csv file
df = pd.read_csv("mileage.csv")

# Convert start_date and end_date columns to datetime type
df['start_date'] = pd.to_datetime(df['start_date'])
df['end_date'] = pd.to_datetime(df['end_date'])

# Compute the total mileage
df['total_mileage'] = df['end_meter'] - df['start_meter']

# Compute the total number of days
df['total_days'] = (df['end_date'] - df['start_date']).dt.total_seconds() / (24 * 60 * 60)

# Group the data by year
grouped_data = df.groupby(df['start_date'].dt.year)

# Compute the average, frequency, and total mileage
avg_mileage = grouped_data['total_mileage'].mean()
freq_mileage = grouped_data['total_mileage'].count() / len(df)
total_mileage = grouped_data['total_mileage'].sum()

# Compute the average, frequency, and total days
avg_days = grouped_data['total_days'].mean()
freq_days = grouped_data['total_days'].count() / len(df)
total_days = grouped_data['total_days'].sum()

# Combine all the aggregations in a summary statistics table
summary_stats = pd.concat([avg_mileage, freq_mileage, total_mileage, avg_days, freq_days, total_days], axis=1)
summary_stats.columns = ['Average Mileage', 'Frequency Mileage', 'Total Mileage', 'Average Days', 'Frequency Days', 'Total Days']

# Limit the decimal point for frequency values to 2
summary_stats['Frequency Mileage'] = summary_stats['Frequency Mileage'].round(2)
summary_stats['Frequency Days'] = summary_stats['Frequency Days'].round(2)

# Group the data by mileage_type, unit_description, car_type, class, category and car_size per year
grouped_data = df.groupby([df['start_date'].dt.year, 'mileage_type', 'unit_description', 'car_type', 'class', 'category', 'car_size'])

# Compute the average, frequency, and total mileage
avg_mileage = grouped_data['total_mileage'].mean()
freq_mileage = grouped_data['total_mileage'].count() / len(df)
total_mileage = grouped_data['total_mileage'].sum()

# Compute the average, frequency, and total days
avg_days = grouped_data['total_days'].mean()
freq_days = grouped_data['total_days'].count() / len(df)
total_days = grouped_data['total_days'].sum()

# Combine all the aggregations in a summary statistics table
summary_stats = pd.concat([avg_mileage])
