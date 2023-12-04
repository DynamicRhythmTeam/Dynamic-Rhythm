from dotenv import load_dotenv 
load_dotenv() 
import spotipy
from spotipy.oauth2 import SpotifyOAuth 

scope = "user-read-currently-playing"

sp= spotipy.Spotify(auth_manager=SpotifyOAuth(scope=scope)) 

print(sp.artist('3AA28KZvwAUcZuOKwyblJQ')['name'])


test = sp.search('Gorillaz')

for idx, item in enumerate(test['tracks']['items']): 
    track = item['name'] 
    print(idx+1,track) 
    prev = item['preview_url'] 
    print(prev)

print()

spotify = spotipy.Spotify(client_credentials_manager=SpotifyClientCredentials())

lz_uri = spotify.search(input())
results = spotify.artist_top_tracks(lz_uri)

for track in results['tracks'][:10]:
    print('track    : ' + track['name'])
    print('audio    : ' + track['preview_url'])
    print('cover art: ' + track['album']['images'][0]['url'])
    print()