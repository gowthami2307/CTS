SELECT speaker_name,
COUNT(*) total_sessions
FROM Sessions
GROUP BY speaker_name
HAVING COUNT(*) > 1;