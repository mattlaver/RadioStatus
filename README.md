# RadioStatus
Simple API to return what's playing on the radio. Currently only supports BBC Radio stations.

# Usage

Only one Endpoint:

```
GET api/v1/station/{{station}}/playing
```

Which returns:

```
{
    "artist": "artist",
    "title": "title"
}
```

Supported Stations:

```
bbc_6music
```