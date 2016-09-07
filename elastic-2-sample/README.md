# Elasticsearch

## Sample Data to Play With

Best way to explore Elasticsearch is to have some sample data loaded into it and explore that through Elasticsearch's amazing interface. Here is a small, sample movies data that you can load into Elasticsearch through Sense.

```
PUT /movie-app/movies/1
{
    "name": "Se7en",
    "releaseYear": 1995,
    "rating": 8.6,
    "ratingCount": 1031122,
    "tags": [
        "serial killer", "detectives"
    ],
    "mainActors": [
        { "name": "Morgan Freeman", "playing": "Somerset" },
        { "name": "Brad Pitt", "playing": "Mills" }
    ]
}

PUT /movie-app/movies/2
{
    "name": "The Dark Knight",
    "releaseYear": 2008,
    "rating": 8.6,
    "ratingCount": 1687800,
    "tags": [
        "gotham", "fight", "superheros", "batman"
    ],
    "mainActors": [
        { "name": "Christian Bale", "playing": "Bruce Wayne" },
        { "name": "Heath Ledger", "playing": "Joker" },
        { "name": "Morgan Freeman", "playing": "Lucius Fox" }
    ]
}

PUT /movie-app/movies/3
{
    "name": "Slumdog Millionaire",
    "releaseYear": 2008,
    "rating": 8.0,
    "ratingCount": 644922,
    "tags": [
        "millionaire", "luck", "rich", "india"
    ],
    "mainActors": [
        { "name": "Dev Patel", "playing": "Older Jamal" },
        { "name": "Anil Kapoor", "playing": "Prem" },
        { "name": "Freida Pinto", "playing": "Older Latika" }
    ]
}

PUT /movie-app/movies/4
{
    "name": "The Dark Knight Rises",
    "releaseYear": 2012,
    "rating": 8.5,
    "ratingCount": 1152348,
    "tags": [
        "gotham", "fight", "superheros", "batman", "catwoman"
    ],
    "mainActors": [
        { "name": "Christian Bale", "playing": "Bruce Wayne" },
        { "name": "Anne Hathaway", "playing": "Selina" },
        { "name": "Joseph Gordon-Levitt", "playing": "Blake" },
        { "name": "Morgan Freeman", "playing": "Lucius Fox" }
    ]
}

PUT /movie-app/movies/5
{
    "name": "Inception",
    "releaseYear": 2010,
    "rating": 8.8,
    "ratingCount": 1478535,
    "tags": [
        "dream", "sleep", "steal"
    ],
    "mainActors": [
        { "name": "Leonardo DiCaprio", "playing": "Cobb" },
        { "name": "Joseph Gordon-Levitt", "playing": "Arthur" },
        { "name": "Ellen Page", "playing": "Ariadne" },
        { "name": "Michael Caine", "playing": "Miles" }
    ]
}

PUT /movie-app/movies/6
{
    "name": "Star Trek Into Darkness",
    "releaseYear": 2013,
    "rating": 7.8,
    "ratingCount": 398587,
    "tags": [
        "enterprise", "space", "crew"
    ],
    "mainActors": [
        { "name": "Chris Pine", "playing": "Kirk" },
        { "name": "Zachary Quinto", "playing": "Spock" },
        { "name": "Zoe Saldana", "playing": "Uhura" },
        { "name": "Benedict Cumberbatch", "playing": "Khan" }
    ]
}

PUT /movie-app/movies/7
{
    "name": "Star Trek",
    "releaseYear": 2009,
    "rating": 8.0,
    "ratingCount": 507480,
    "tags": [
        "enterprise", "space", "crew"
    ],
    "mainActors": [
        { "name": "Chris Pine", "playing": "Kirk" },
        { "name": "Zachary Quinto", "playing": "Spock" },
        { "name": "Zoe Saldana", "playing": "Uhura" },
        { "name": "Leonard Nimoy", "playing": "Spock Prime" }
    ]
}

PUT /movie-app/movies/8
{
    "name": "Star Trek Beyond",
    "releaseYear": 2016,
    "rating": 7.4,
    "ratingCount": 69010,
    "tags": [
        "enterprise", "space", "crew"
    ],
    "mainActors": [
        { "name": "Chris Pine", "playing": "Captain James T. Kirk" },
        { "name": "Zachary Quinto", "playing": "Commander Spock" },
        { "name": "Zoe Saldana", "playing": "Lieutenant Uhura" },
        { "name": "Sofia Boutella", "playing": "Jaylah" },
        { "name": "Idris Elba", "playing": "Krall" }
    ]
}

PUT /movie-app/movies/9
{
    "name": "Star Wars: The Force Awakens",
    "releaseYear": 2015,
    "rating": 8.2,
    "ratingCount": 576413,
    "tags": [
        "space", "resistance", "empire"
    ],
    "mainActors": [
        { "name": "Harrison Ford", "playing": "Han Solo" },
        { "name": "Mark Hamill", "playing": "Luke Skywalker" },
        { "name": "Carrie Fisher", "playing": "Princess Leia" },
        { "name": "Adam Driver", "playing": "Kylo Ren" },
        { "name": "Daisy Ridley", "playing": "Rey" },
        { "name": "John Boyega", "playing": "Finn" }
    ]
}

PUT /movie-app/movies/10
{
    "name": "Star Wars: The Force Awakens",
    "releaseYear": 2015,
    "rating": 8.2,
    "ratingCount": 576413,
    "tags": [
        "space", "resistance", "empire", "force"
    ],
    "mainActors": [
        { "name": "Harrison Ford", "playing": "Han Solo" },
        { "name": "Mark Hamill", "playing": "Luke Skywalker" },
        { "name": "Carrie Fisher", "playing": "Princess Leia" },
        { "name": "Adam Driver", "playing": "Kylo Ren" },
        { "name": "Daisy Ridley", "playing": "Rey" },
        { "name": "John Boyega", "playing": "Finn" }
    ]
}

PUT /movie-app/movies/11
{
    "name": "Star Wars: Episode III - Revenge of the Sith",
    "releaseYear": 2005,
    "rating": 7.6,
    "ratingCount": 523172,
    "tags": [
        "space", "resistance", "empire", "force"
    ],
    "mainActors": [
        { "name": "Ewan McGregor", "playing": "Obi-Wan Kenobi" },
        { "name": "Natalie Portman", "playing": "Padmé" },
        { "name": "Hayden Christensen", "playing": "Anakin Skywalker" }
    ]
}
```

## Simple Queries

Based on the above data, we can issue simple queries. For example, we can look for movies which has `star` in it's name:

```
GET movie-app/movies/_search
{
  "query": {
    "match": {
      "name": "star"
    }
  }
}
```

## [Nested Type](https://www.elastic.co/guide/en/elasticsearch/reference/2.4/nested.html)

Arrays of inner [object fields](https://www.elastic.co/guide/en/elasticsearch/reference/2.4/object.html) do not work the way you may expect. Lucene has no concept of inner objects, so Elasticsearch flattens object hierarchies into a simple list of field names and values. For instance:

```
PUT my_index/my_type/1
{
  "group" : "fans",
  "user" : [ 
    {
      "first" : "John",
      "last" :  "Smith"
    },
    {
      "first" : "Alice",
      "last" :  "White"
    }
  ]
}
```

would be transformed internally into a document that looks more like this:

```
{
  "group" :        "fans",
  "user.first" : [ "alice", "john" ],
  "user.last" :  [ "smith", "white" ]
}
```

The `user.first` and `user.last` fields are flattened into multi-value fields, and the association between `alice` and `white` is lost. This document would incorrectly match a query for `alice` AND `smith`:

```
GET my_index/_search
{
  "query": {
    "bool": {
      "must": [
        { "match": { "user.first": "Alice" }},
        { "match": { "user.last":  "Smith" }}
      ]
    }
  }
}
```

## [Aggregations](https://www.elastic.co/guide/en/elasticsearch/guide/2.x/aggregations.html)

So far so straight forward. Let's make this query a bit rich with an aggregation to get the release years available on our search result:

```
GET movie-app/movies/_search
{
  "query": {
    "term": {
      "name": {
        "value": "star"
      }
    }
  },
  "aggs": {
    "years": {
      "terms": {
        "field": "releaseYear"
      }
    }
  }
}
```

This will give us the below result:

```
{
  "took": 13,
  "timed_out": false,
  "_shards": {
    "total": 5,
    "successful": 5,
    "failed": 0
  },
  "hits": {
    "total": 5,
    "max_score": 0.7554128,
    "hits": [
      {
        "_index": "movie-app",
        "_type": "movies",
        "_id": "8",
        "_score": 0.7554128,
        "_source": {
          "name": "Star Trek Beyond",
          "releaseYear": 2016,
          "rating": 7.4,
          "ratingCount": 69010,
          "tags": [
            "enterprise",
            "space",
            "crew"
          ],
          "mainActors": [
            {
              "name": "Chris Pine",
              "playing": "Captain James T. Kirk"
            },
            {
              "name": "Zachary Quinto",
              "playing": "Commander Spock"
            },
            {
              "name": "Zoe Saldana",
              "playing": "Lieutenant Uhura"
            },
            {
              "name": "Sofia Boutella",
              "playing": "Jaylah"
            },
            {
              "name": "Idris Elba",
              "playing": "Krall"
            }
          ]
        }
      },
      {
        "_index": "movie-app",
        "_type": "movies",
        "_id": "6",
        "_score": 0.70273256,
        "_source": {
          "name": "Star Trek Into Darkness",
          "releaseYear": 2013,
          "rating": 7.8,
          "ratingCount": 398587,
          "tags": [
            "enterprise",
            "space",
            "crew"
          ],
          "mainActors": [
            {
              "name": "Chris Pine",
              "playing": "Kirk"
            },
            {
              "name": "Zachary Quinto",
              "playing": "Spock"
            },
            {
              "name": "Zoe Saldana",
              "playing": "Uhura"
            },
            {
              "name": "Benedict Cumberbatch",
              "playing": "Khan"
            }
          ]
        }
      },
      {
        "_index": "movie-app",
        "_type": "movies",
        "_id": "10",
        "_score": 0.6609862,
        "_source": {
          "name": "Star Wars: The Force Awakens",
          "releaseYear": 2015,
          "rating": 8.2,
          "ratingCount": 576413,
          "tags": [
            "space",
            "resistance",
            "empire",
            "force"
          ],
          "mainActors": [
            {
              "name": "Harrison Ford",
              "playing": "Han Solo"
            },
            {
              "name": "Mark Hamill",
              "playing": "Luke Skywalker"
            },
            {
              "name": "Carrie Fisher",
              "playing": "Princess Leia"
            },
            {
              "name": "Adam Driver",
              "playing": "Kylo Ren"
            },
            {
              "name": "Daisy Ridley",
              "playing": "Rey"
            },
            {
              "name": "John Boyega",
              "playing": "Finn"
            }
          ]
        }
      },
      {
        "_index": "movie-app",
        "_type": "movies",
        "_id": "7",
        "_score": 0.625,
        "_source": {
          "name": "Star Trek",
          "releaseYear": 2009,
          "rating": 8,
          "ratingCount": 507480,
          "tags": [
            "enterprise",
            "space",
            "crew"
          ],
          "mainActors": [
            {
              "name": "Chris Pine",
              "playing": "Kirk"
            },
            {
              "name": "Zachary Quinto",
              "playing": "Spock"
            },
            {
              "name": "Zoe Saldana",
              "playing": "Uhura"
            },
            {
              "name": "Leonard Nimoy",
              "playing": "Spock Prime"
            }
          ]
        }
      },
      {
        "_index": "movie-app",
        "_type": "movies",
        "_id": "11",
        "_score": 0.3125,
        "_source": {
          "name": "Star Wars: Episode III - Revenge of the Sith",
          "releaseYear": 2005,
          "rating": 7.6,
          "ratingCount": 523172,
          "tags": [
            "space",
            "resistance",
            "empire",
            "force"
          ],
          "mainActors": [
            {
              "name": "Ewan McGregor",
              "playing": "Obi-Wan Kenobi"
            },
            {
              "name": "Natalie Portman",
              "playing": "Padmé"
            },
            {
              "name": "Hayden Christensen",
              "playing": "Anakin Skywalker"
            }
          ]
        }
      }
    ]
  },
  "aggregations": {
    "years": {
      "doc_count_error_upper_bound": 0,
      "sum_other_doc_count": 0,
      "buckets": [
        {
          "key": 2005,
          "doc_count": 1
        },
        {
          "key": 2009,
          "doc_count": 1
        },
        {
          "key": 2013,
          "doc_count": 1
        },
        {
          "key": 2015,
          "doc_count": 1
        },
        {
          "key": 2016,
          "doc_count": 1
        }
      ]
    }
  }
}
```

We can even go further and get the rating range with the count of hits.

```
{
  "took": 9,
  "timed_out": false,
  "_shards": {
    "total": 5,
    "successful": 5,
    "failed": 0
  },
  "hits": {
    "total": 5,
    "max_score": 0.7554128,
    "hits": [
      {
        "_index": "movie-app",
        "_type": "movies",
        "_id": "8",
        "_score": 0.7554128,
        "_source": {
          "name": "Star Trek Beyond",
          "releaseYear": 2016,
          "rating": 7.4,
          "ratingCount": 69010,
          "tags": [
            "enterprise",
            "space",
            "crew"
          ],
          "mainActors": [
            {
              "name": "Chris Pine",
              "playing": "Captain James T. Kirk"
            },
            {
              "name": "Zachary Quinto",
              "playing": "Commander Spock"
            },
            {
              "name": "Zoe Saldana",
              "playing": "Lieutenant Uhura"
            },
            {
              "name": "Sofia Boutella",
              "playing": "Jaylah"
            },
            {
              "name": "Idris Elba",
              "playing": "Krall"
            }
          ]
        }
      },
      {
        "_index": "movie-app",
        "_type": "movies",
        "_id": "6",
        "_score": 0.70273256,
        "_source": {
          "name": "Star Trek Into Darkness",
          "releaseYear": 2013,
          "rating": 7.8,
          "ratingCount": 398587,
          "tags": [
            "enterprise",
            "space",
            "crew"
          ],
          "mainActors": [
            {
              "name": "Chris Pine",
              "playing": "Kirk"
            },
            {
              "name": "Zachary Quinto",
              "playing": "Spock"
            },
            {
              "name": "Zoe Saldana",
              "playing": "Uhura"
            },
            {
              "name": "Benedict Cumberbatch",
              "playing": "Khan"
            }
          ]
        }
      },
      {
        "_index": "movie-app",
        "_type": "movies",
        "_id": "10",
        "_score": 0.6609862,
        "_source": {
          "name": "Star Wars: The Force Awakens",
          "releaseYear": 2015,
          "rating": 8.2,
          "ratingCount": 576413,
          "tags": [
            "space",
            "resistance",
            "empire",
            "force"
          ],
          "mainActors": [
            {
              "name": "Harrison Ford",
              "playing": "Han Solo"
            },
            {
              "name": "Mark Hamill",
              "playing": "Luke Skywalker"
            },
            {
              "name": "Carrie Fisher",
              "playing": "Princess Leia"
            },
            {
              "name": "Adam Driver",
              "playing": "Kylo Ren"
            },
            {
              "name": "Daisy Ridley",
              "playing": "Rey"
            },
            {
              "name": "John Boyega",
              "playing": "Finn"
            }
          ]
        }
      },
      {
        "_index": "movie-app",
        "_type": "movies",
        "_id": "7",
        "_score": 0.625,
        "_source": {
          "name": "Star Trek",
          "releaseYear": 2009,
          "rating": 8,
          "ratingCount": 507480,
          "tags": [
            "enterprise",
            "space",
            "crew"
          ],
          "mainActors": [
            {
              "name": "Chris Pine",
              "playing": "Kirk"
            },
            {
              "name": "Zachary Quinto",
              "playing": "Spock"
            },
            {
              "name": "Zoe Saldana",
              "playing": "Uhura"
            },
            {
              "name": "Leonard Nimoy",
              "playing": "Spock Prime"
            }
          ]
        }
      },
      {
        "_index": "movie-app",
        "_type": "movies",
        "_id": "11",
        "_score": 0.3125,
        "_source": {
          "name": "Star Wars: Episode III - Revenge of the Sith",
          "releaseYear": 2005,
          "rating": 7.6,
          "ratingCount": 523172,
          "tags": [
            "space",
            "resistance",
            "empire",
            "force"
          ],
          "mainActors": [
            {
              "name": "Ewan McGregor",
              "playing": "Obi-Wan Kenobi"
            },
            {
              "name": "Natalie Portman",
              "playing": "Padmé"
            },
            {
              "name": "Hayden Christensen",
              "playing": "Anakin Skywalker"
            }
          ]
        }
      }
    ]
  },
  "aggregations": {
    "rating_ranges": {
      "buckets": [
        {
          "key": "*-5.0",
          "to": 5,
          "to_as_string": "5.0",
          "doc_count": 0
        },
        {
          "key": "5.0-6.0",
          "from": 5,
          "from_as_string": "5.0",
          "to": 6,
          "to_as_string": "6.0",
          "doc_count": 0
        },
        {
          "key": "6.0-7.0",
          "from": 6,
          "from_as_string": "6.0",
          "to": 7,
          "to_as_string": "7.0",
          "doc_count": 0
        },
        {
          "key": "7.0-7.5",
          "from": 7,
          "from_as_string": "7.0",
          "to": 7.5,
          "to_as_string": "7.5",
          "doc_count": 1
        },
        {
          "key": "7.5-8.0",
          "from": 7.5,
          "from_as_string": "7.5",
          "to": 8,
          "to_as_string": "8.0",
          "doc_count": 2
        },
        {
          "key": "8.0-8.5",
          "from": 8,
          "from_as_string": "8.0",
          "to": 8.5,
          "to_as_string": "8.5",
          "doc_count": 2
        },
        {
          "key": "8.5-9.0",
          "from": 8.5,
          "from_as_string": "8.5",
          "to": 9,
          "to_as_string": "9.0",
          "doc_count": 0
        },
        {
          "key": "10.0-*",
          "from": 10,
          "from_as_string": "10.0",
          "doc_count": 0
        }
      ]
    },
    "years": {
      "doc_count_error_upper_bound": 0,
      "sum_other_doc_count": 0,
      "buckets": [
        {
          "key": 2005,
          "doc_count": 1
        },
        {
          "key": 2009,
          "doc_count": 1
        },
        {
          "key": 2013,
          "doc_count": 1
        },
        {
          "key": 2015,
          "doc_count": 1
        },
        {
          "key": 2016,
          "doc_count": 1
        }
      ]
    }
  }
}
```

The aggregation results we have here can help us enrich our filters and enable us to give smart filters to the user. This is widely known as [Faceted search](https://en.wikipedia.org/wiki/Faceted_search).

> :warning: The above aggregations apply themselves [based on the query we are issuig along with them](https://www.elastic.co/guide/en/elasticsearch/guide/2.x/_filtering_queries.html).
> However, there are ways to [apply a seperate filter to an aggregation](https://www.elastic.co/guide/en/elasticsearch/guide/2.x/_filter_bucket.html) or
> [just for the query but not the aggregation](https://www.elastic.co/guide/en/elasticsearch/guide/2.x/_post_filter.html).
>
> But there seems to be [no way to apply a reducer to the result of an aggregation](https://github.com/elastic/elasticsearch/issues/8110#issuecomment-69891827).

### Aggregation on Arrays

Aggregations can also be applied to arrays. In some cases, it will just work as you expect them to without any tweaks. 
For example, we have `tags` string array and we can apply the `terms` aggregation to that directly.

```
GET movie-app/movies/_search
{
  "size": 0, 
  "aggs": {
    "years": {
      "terms": {
        "field": "tags"
      }
    }
  }
}
``` 

The result:

```
{
  "took": 4,
  "timed_out": false,
  "_shards": {
    "total": 5,
    "successful": 5,
    "failed": 0
  },
  "hits": {
    "total": 11,
    "max_score": 0,
    "hits": []
  },
  "aggregations": {
    "years": {
      "doc_count_error_upper_bound": 0,
      "sum_other_doc_count": 11,
      "buckets": [
        {
          "key": "space",
          "doc_count": 5
        },
        {
          "key": "crew",
          "doc_count": 3
        },
        {
          "key": "enterprise",
          "doc_count": 3
        },
        {
          "key": "batman",
          "doc_count": 2
        },
        {
          "key": "empire",
          "doc_count": 2
        },
        {
          "key": "fight",
          "doc_count": 2
        },
        {
          "key": "force",
          "doc_count": 2
        },
        {
          "key": "gotham",
          "doc_count": 2
        },
        {
          "key": "resistance",
          "doc_count": 2
        },
        {
          "key": "superheros",
          "doc_count": 2
        }
      ]
    }
  }
}
```