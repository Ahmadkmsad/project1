from telethon.sync import TelegramClient
import csv


api_id = YOUR_API_ID
api_hash = 'YOUR_API_HASH'


invite_link = 'https://t.me/joinchat/waFBpu7aTUEzMzQ8'


with TelegramClient('session_name', api_id, api_hash) as client:
   
    channel = client.resolve_invite(invite_link)

  
    members = client.get_participants(channel)

    # Save the members in a CSV file
    with open('members.csv', 'w', newline='', encoding='utf-8') as csvfile:
        writer = csv.writer(csvfile)
        writer.writerow(['Name', 'Username', 'Phone'])
        for member in members:
            name = member.first_name if member.first_name else ""
            username = member.username if member.username else ""
            phone = member.phone if member.phone else ""
            writer.writerow([name, username, phone])

print('Members scraped and saved successfully.')
